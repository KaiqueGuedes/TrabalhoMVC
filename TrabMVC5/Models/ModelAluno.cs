using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TMVC5.Models
{
    public class ModelAluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAluno { get; set; }
        public int RA { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }


     }
}