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
        public string Validaremprestimos(Emprestimo NovoEmprestimo)
        {


            string erros = "";



            for (int i = 0; i < EmprestimosCadastrados.Length; i++)
            {

                if (NovoEmprestimo == null || EmprestimosCadastrados[i] ==null)
                {
                                      
                    continue;
                }

                else if (EmprestimosCadastrados[i].Amigo != null && EmprestimosCadastrados[i].Amigo == NovoEmprestimo.Amigo)
                {
                    erros += "Não foi possivel completar o processo pois este amigo ja possui um emprestimo \n";
                    break; 

                }
            }





            // for (int i = 0; i < AmigosCadastrados.Length; i++)
            //{
            //     if (AmigosCadastrados[i] != null && Telefone == AmigosCadastrados[i].Telefone)
            // {
            //          erros += "Não pode existir Telefones duplicados Digite outro número \n";
            //         break;
            //      }
            //  }

            // if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            //      erros += "campo Nome É Obrigatorio e deve conter ao menos três caracteres \n ";

            //for (int i = 0; i < AmigosCadastrados.Length; i++)
            // {
            //      if (AmigosCadastrados[i] != null && NomeResponsavel == AmigosCadastrados[i].NomeResponsavel)
            //     {
            //         erros += "Não pode existir nomes responsáveis duplicados escolha outro nome \n";
            //         break;
            //     }
            //  }

            //  if (string.IsNullOrWhiteSpace(NomeResponsavel) || NomeResponsavel.Length < 3)
            //  erros += "Campo Nome responsável Não pode ser nulo e deve conter ao menos três caracteres \n";

            //  if (string.IsNullOrWhiteSpace(Telefone) || Telefone.Length < 10 || Telefone.Length > 13)
            //      erros += "Campo telefone Não pode ser nulo ! E deve ser no formato do Exemplo... Ex: 00 123456789\n";





            return erros;

        }

    }

}






