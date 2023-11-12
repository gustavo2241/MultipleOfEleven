using System.ComponentModel.DataAnnotations;

namespace MultipleOfEleven.Application.Models
{
    public class PostLogin
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Password { get; set; }
    }
}
