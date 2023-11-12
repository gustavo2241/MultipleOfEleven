using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MultipleOfEleven.Application.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MultipleOfEleven.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(PostLogin user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("Request do client inválido");
                }

                if (user.Username == _configuration["UserAPI"] && user.Password == _configuration["PassAPI"])
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ValidateIfNull(Environment.GetEnvironmentVariable("SECRET_KEY_256"), "secret_key")));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokenOptions = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(Array.Empty<Claim>()),
                        Expires = DateTime.UtcNow.AddHours(1),
                        SigningCredentials = signinCredentials
                    };
                    var token = tokenHandler.CreateToken(tokenOptions);
                    user.Password = "";
                    return Ok(new { Token = tokenHandler.WriteToken(token) });
                }

                return Unauthorized();
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }

        private TokenValidationParameters GetValidationParameters()
        {
            var secretKey = ValidateIfNull(Environment.GetEnvironmentVariable("SECRET_KEY_256"), "secret_key");
            var key = Encoding.ASCII.GetBytes(secretKey);
            return new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
        }

        private static string ValidateIfNull(string? value, string? name)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value), $"{name} cannot be null");

            return value;
        }

    }
}