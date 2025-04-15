using Projeto_Clube_do_livro_2025.ModuloAmigo;
using Projeto_Clube_do_livro_2025.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloEmprestimo
{
   public class Emprestimo
    {
        public int Id;
        public Amigo Amigo;
        public Revista Revista;
        public DateTime Data;
        public string Situacao;

        public Emprestimo (Amigo amigo, Revista revista, DateTime data, string situacao)
        {
            Amigo = amigo;
            Revista = revista;
            Data = data;
            Situacao = situacao;
        }
    }
}
