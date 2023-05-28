using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_crud.Models
{
    public class Usuarios
    {
        [Key]
        public int Email { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Email")]
        public string Senha { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Senha")]
        public string OfficeLocation { get; set; }
    }
}
