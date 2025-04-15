using Projeto_Clube_do_livro_2025.compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloEmprestimo
{
    public class RepositorioEmprestimo
    {
        public Emprestimo[] EmprestimosCadastrados = new Emprestimo[100];
        public int contadorEmprestimo = 0;


        public void CadastrarEmprestimo(Emprestimo NovoEmprestimo)
        {

            NovoEmprestimo.Id = GeradorId.GerarIdEmprestimo();
            EmprestimosCadastrados[contadorEmprestimo++] = NovoEmprestimo;


        }
        public Emprestimo[] VizualizarEmprestimo()
        {

            return EmprestimosCadastrados;

        }





    }



}