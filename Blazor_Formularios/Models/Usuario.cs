using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Formularios.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatorio")]
        [StringLength(10,ErrorMessage ="O nome não pode exceder 10 caracteres")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage ="O formato do email é inválido")]
        [Required(ErrorMessage = "O email é Obrigatorio")]
        public string Email { get; set; }

        [Range(18,80, ErrorMessage = "A idade deve estar entre {0} e {1}")]
        public int Idade { get; set; }
    }
}
