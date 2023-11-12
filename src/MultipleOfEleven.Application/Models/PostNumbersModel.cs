using System.ComponentModel.DataAnnotations;

namespace MultipleOfEleven.Application.Models
{
    public class PostNumbersModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string[] numbers { get; set; }
    }
}
