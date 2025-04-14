using Projeto_Clube_do_livro_2025.ModuloCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloRevista
{
    public class Revista
    {
        public int Id;
        public string Titulo;
        public int NumeroEdicao;
        public DateTime AnoPublicacao;
        public string StatusEmprestimo;
        public Caixa Caixa;

        public Revista(string titulo, int numeroEdicao, DateTime anoPublicacao, string statusEmprestimo, Caixa caixa)
        {
            Titulo = titulo;
            NumeroEdicao = numeroEdicao;
            AnoPublicacao = anoPublicacao;
            StatusEmprestimo = statusEmprestimo;
            Caixa = caixa;
        }
    }
}
