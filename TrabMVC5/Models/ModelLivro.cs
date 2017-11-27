using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TMVC5.Models
{
    public class ModelLivro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLivro { get; set; }
        [Required]
        [StringLength(35, ErrorMessage = "Campo nome- máximo 35 caracteres")]
        public String autor{ get; set; }
        public String descri { get; set; }
        public String editora { get; set; }
        public String genero { get; set; }
        public String livro { get; set; }
        public int qtd { get; set; }
    }
}