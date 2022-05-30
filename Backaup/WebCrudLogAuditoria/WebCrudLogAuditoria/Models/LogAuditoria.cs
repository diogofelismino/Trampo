using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCrudLogAuditoria.Models
{

    [Table("LogAuditoria")]
    public class LogAuditoria
    {


        [Column("Id")]
        [Display(Name = "Código")]

        public int Id { get; set; }

        [Column("DetalhesAuditoria")]
        [Display(Name = "Detalhes Auditoria")]

        public string DetalhesAuditoria { get; set; }

        [Column("EmailUsuario")]
        [Display(Name = "Email Usuario")]

        public string EmailUsuario { get; set; } 

    }
}
