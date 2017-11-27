using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMVC5.Models
{
    public class ModelEmprestimo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEmprestimo { get; set; }
        public int RA { get; set; }
        public int livro_id{ get; set; }
        public int qtd  { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Required(ErrorMessage = "Informe a data dd/mm/yyy")]
        public DateTime data_emp { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Required(ErrorMessage = "Informe a data dd/mm/yyy")]
        public DateTime data_devol { get; set; }

    }
}