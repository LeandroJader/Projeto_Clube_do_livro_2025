using Projeto_Clube_do_livro_2025.ModuloAmigo;
using Projeto_Clube_do_livro_2025.ModuloCaixa;
using Projeto_Clube_do_livro_2025.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
{
    public class TelaEmprestimo
    {
        public RepositorioAmigo repositorioAmigo;
        public RepositorioRevista repositorioRevista;
        public RepositorioCaixa repositoriocaixa;
        public RepositorioEmprestimo repositorioEmprestimo;

        public TelaEmprestimo(RepositorioAmigo repositorioAmigo, RepositorioRevista repositorioRevista, RepositorioCaixa repositoriocaixa, RepositorioEmprestimo repositorioEmprestimo)
        {
            this.repositorioAmigo = repositorioAmigo;
            this.repositorioRevista = repositorioRevista;
            this.repositoriocaixa = repositoriocaixa;
            this.repositorioEmprestimo = repositorioEmprestimo;
        }

        public static string MenuEmprestimo()
        {
            Console.Clear();
            Console.WriteLine("informe opção que deseja");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine("1- para cadastar um novo empréstimo");
            Console.WriteLine("2- para Registrar uma devolução");
            Console.WriteLine("3- para obter Data Devolução");
            string Opcao = Console.ReadLine();
            return Opcao;

        }

       public void VizualizarAmigos()
        {

            Console.WriteLine("vizualizando amigos ");
            Console.WriteLine();

            Console.WriteLine("{0, -10} | {1, -15} | {2,-20} |  {3,-15} ",
                                 "Id", "nome", "nome responsavel", "telefone"
                      );
            Console.WriteLine();

            Amigo[] amigosCadastrados = repositorioAmigo.SelecionarAmigos();

            for (int i = 0; i < amigosCadastrados.Length; i++)
            {
                Amigo a = amigosCadastrados[i];

                if (a == null) continue;

                else
                {

                    Console.WriteLine("{0, -10} | {1, -15} | {2,-20} |  {3,-15} ",
                                    a.Id, a.Nome, a.NomeResponsavel, a.Telefone
                         );

                }
            }

        }

        public void vizualizarRevistas()
        {
            Console.WriteLine("{0, -10} | {1, -15} | {2, -10}     | {3,-15} |   {4, -15} |        {5, -15}",
                               "Id", "Título", "Nº Edição", " Ano.public", "status disp, ", " caixa");

            Console.WriteLine();

            Revista[] revistascadastradas = repositorioRevista.VizualizarRevistas();


            for (int i = 0; i < revistascadastradas.Length; i++)
            {
                if (revistascadastradas[i] == null) continue;

                else
                {
                    Revista r = revistascadastradas[i];

                    Console.WriteLine("{0, -10} | {1, -15} | {2, -10}     | {3,-15} |   {4, -15} |        {5, -15}",
                                       r.Id, r.Titulo, r.NumeroEdicao, r.AnoPublicacao.ToShortDateString(), r.StatusEmprestimo, r.Caixa.Etiqueta);


                    Console.WriteLine();
                    break;
                }

            }
            Console.WriteLine("pressione Enter para continuar");
            Console.ReadLine();
        }



        public void CadastrarEmprestimo()
        {
            Console.WriteLine("Amigos Cadastrados");
            VizualizarAmigos();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Revistas Cadastradas");
            vizualizarRevistas();
            Console.WriteLine("---------------------------------------------------------------");


            Emprestimo NovoEmprestimo = ObterDadosEmprestimo();
            repositorioEmprestimo.CadastrarEmprestimo(NovoEmprestimo);



        }
        public Emprestimo ObterDadosEmprestimo()
        {
            Console.WriteLine("Informe o Id do amigo para receber o emprestimo");
            int IdEscolhidoAmigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Id da revista que será emprestada ");
            int IdEscolhidoRevista = Convert.ToInt32(Console.ReadLine());

            DateTime DataInicialEmprestimo = DateTime.Now;

            Console.WriteLine("Informe a situação do emprestimo");
            string SituacaoEmprestimo = Console.ReadLine();

            Amigo AmigoSelecionado = repositorioAmigo.SelecionarAmigoPorId(IdEscolhidoAmigo);
            Revista RevistaSelecionada = repositorioRevista.SelecionarRevistaPorId(IdEscolhidoRevista);

            Emprestimo NovoEmprestimo = new Emprestimo(AmigoSelecionado, RevistaSelecionada, DataInicialEmprestimo,SituacaoEmprestimo);

            return NovoEmprestimo;

        }
        public void VizualizarEmprestimos()
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3,-15} ",
                              "amigo", "revista", "data.abertura", "situação");

            Console.WriteLine();

            Emprestimo[] emprestimosCadastrados = repositorioEmprestimo.VizualizarEmprestimo();


            for (int i = 0; i < emprestimosCadastrados.Length ; i++)
            {
                if (emprestimosCadastrados[i] == null) continue;

                else
                {
                    Emprestimo e = emprestimosCadastrados[i];

                    Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | ",
                                       e.Amigo.Nome, e.Revista.Titulo, e.Data, e.Situacao);
                    Console.WriteLine();

                }
            }

            Console.WriteLine("pressione Enter para Continuar ");
            Console.ReadLine();
        }



    }


}

