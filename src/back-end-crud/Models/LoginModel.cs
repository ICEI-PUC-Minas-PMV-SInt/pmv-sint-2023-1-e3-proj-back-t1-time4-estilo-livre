using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_crud.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string Senha { get; set; }
    }
}
