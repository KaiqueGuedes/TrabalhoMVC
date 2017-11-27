using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TMVC5.Models
{
    public class ModelContexto:DbContext
    {
        public ModelContexto(): base("TMVC5") { }

        public DbSet<ModelAluno> aluno { get; set; }
        public DbSet<ModelBibliotecario> bibliotecario { get; set; }
        public DbSet<ModelLivro> livro { get; set; }
        public DbSet<ModelEmprestimo> emprestimo { get; set; }
 




    }
}