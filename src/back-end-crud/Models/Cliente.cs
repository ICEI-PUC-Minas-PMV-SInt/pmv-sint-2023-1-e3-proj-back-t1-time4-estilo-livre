using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_crud.Models
{
    public class Cliente
    {
        [Key]
        public int clienteId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Nome")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Sobrenome")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Email")]
        public string OfficeLocation { get; set; }
    }
}
