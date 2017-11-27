using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TMVC5.Models
{
    public class ModelBibliotecario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idBibliotecario { get; set; }
        [Required]
        [StringLength(35, ErrorMessage = "Campo nome- máximo 35 caracteres")]
        public string nome { get; set; }
        public int usuario { get; set; }
        public string senha { get; set; }



    }
}