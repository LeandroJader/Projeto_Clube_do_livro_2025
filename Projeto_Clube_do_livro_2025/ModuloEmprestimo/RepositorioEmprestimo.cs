using Projeto_Clube_do_livro_2025.compartilhado;
using Projeto_Clube_do_livro_2025.ModuloAmigo;
using Projeto_Clube_do_livro_2025.ModuloCaixa;
using Projeto_Clube_do_livro_2025.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloEmprestimo
{
    public class RepositorioEmprestimo
    {
        public Emprestimo[] devolucaoRegistradas = new Emprestimo[100];
        public Emprestimo[] EmprestimosCadastrados = new Emprestimo[100];
        public Emprestimo[] EmprestimosEmAberto = new Emprestimo[100];
        public Emprestimo[] EmprestimosFechados = new Emprestimo[100];


        public int contadorEmprestimo = 0;
        public int contadorDevolucao = 0;
        public int contAberto = 0;
        public int contFechado = 0;


        public void CadastrarEmprestimo(Emprestimo NovoEmprestimo)
        {

            NovoEmprestimo.Id = GeradorId.GerarIdEmprestimo();
            EmprestimosCadastrados[contadorEmprestimo++] = NovoEmprestimo;

            EmprestimosEmAberto[contAberto++] = NovoEmprestimo;

        }


        public string ValidarDevolucao(Emprestimo devolucao)
        {
            Console.Clear();
            string erros = "";
            bool encontrou = false;

            for (int i = 0; i < devolucaoRegistradas.Length; i++)
            {
                if (devolucaoRegistradas[i] == null || EmprestimosCadastrados[i] == null)
                {
                    continue;
                }

                if (EmprestimosCadastrados[i].Amigo != null &&
                    EmprestimosCadastrados[i].Amigo == devolucao.Amigo)
                {
                    encontrou = true;
                 
                    break;
                }
            }

            if (!encontrou)
            {
                erros += "Não existe nenhuma devolução pendente deste amigo.\n";
            }

            return erros;
        }



        public Emprestimo [] RegistrarDevolucoes(bool verdadeiro,Emprestimo NovaDevolucao)
        {
            if(verdadeiro == true) { 

            NovaDevolucao.Id = GeradorId.GerarIdDevolucao();
            devolucaoRegistradas[contadorDevolucao++] = NovaDevolucao;

                for (int i = 0; i < devolucaoRegistradas.Length; i++)
                {
                    if (devolucaoRegistradas[i] != null && devolucaoRegistradas[i].Amigo == EmprestimosEmAberto[i].Amigo)
                    {
                        EmprestimosFechados[i] = EmprestimosEmAberto[i];
                        EmprestimosEmAberto[i] = null;
                        EmprestimosCadastrados[i] = null;
                    }
                }
            }
            return EmprestimosCadastrados;
        }


        public Emprestimo[] VizualizarEmprestimo()
        {

            return EmprestimosCadastrados;

        }

         public Emprestimo[] VizualizarEmprestimosEmAberto()
        {
            return EmprestimosEmAberto;

        }

        public Emprestimo[] VizualizarEmprestimosFechados()
        {
            return EmprestimosEmAberto;

        }




        public string Validaremprestimos(Emprestimo NovoEmprestimo)
        {


            string erros = "";



            for (int i = 0; i < EmprestimosCadastrados.Length; i++)
            {

                if (NovoEmprestimo == null || EmprestimosCadastrados[i] == null)
                {

                    continue;
                }

                else if (EmprestimosCadastrados[i].Amigo != null && EmprestimosCadastrados[i].Amigo == NovoEmprestimo.Amigo)
                {
                    erros += "Não foi possivel completar o processo pois este amigo ja possui um emprestimo \n";
                    break;

                }
            }

            return erros;

        }

    }

}






