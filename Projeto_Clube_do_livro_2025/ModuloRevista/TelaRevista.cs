using Projeto_Clube_do_livro_2025.compartilhado;
using Projeto_Clube_do_livro_2025.ModuloCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloRevista
{
    public class TelaRevista
    {
        public RepositorioCaixa repositoriocaixas;
        public RepositorioRevista repositoriorevista;


        public TelaRevista(RepositorioRevista repositoriorevista, RepositorioCaixa repositoriocaixa)
        {

            this.repositoriorevista = repositoriorevista;
            this.repositoriocaixas = repositoriocaixa;

        }
        public static string MenuRevista()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("informe a opção desejada ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("1- para cadastrar revistas");
            Console.WriteLine("2- para vizualizar revistas");
            Console.WriteLine("3- para editar revistas");
            Console.WriteLine("4- para excluir revistas");

            string OpcaoEscolhida = Console.ReadLine();
            return OpcaoEscolhida;

        }


        public void VizualizarCaixas()
        {
            
            Console.WriteLine();

            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3,-10} ",
                                "Id", "etiqueta", "cor", "Dias de emprestimo");

            Console.WriteLine();

            Caixa[] caixascadastradas = repositoriocaixas.VizualizarCaixas();


            for (int i = 0; i < caixascadastradas.Length; i++)
            {
                if (caixascadastradas[i] == null) continue;

                else
                {
                    Caixa a = caixascadastradas[i];

                    Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | ",
                                       a.Id, a.Etiqueta, a.Cor, a.DiasDeEmprestimos);
                    Console.WriteLine();

                }
            }

            Console.WriteLine("pressione Enter para Continuar ");
            Console.ReadLine();
        }


        public void CdastrarRevista()
        {
            Console.WriteLine();            
            Console.WriteLine();

            string erros = "";
            bool consegiuCadastrar = true;
            while (consegiuCadastrar == true)
            {



                Revista NovaRevista = ObterDadosRevista();
                erros = repositoriorevista.Validarrevista(NovaRevista.Titulo, NovaRevista.NumeroEdicao, NovaRevista.AnoPublicacao, NovaRevista.Caixa);


                if (erros.Length > 0)
                {
                    Notificador.ExibirMensagem(erros, ConsoleColor.Red);
                   
                    return;

                }

                else
                {

                    repositoriorevista.CadastrarRevista(NovaRevista);
                    Notificador.ExibirMensagem("Cadastro concluido ", ConsoleColor.Green);
                  
                    consegiuCadastrar = false;
                }

            }

        }




        public Revista ObterDadosRevista()
        {

            Console.Clear();
            int IdCaixas;
            while (true)
            {

                Console.WriteLine(" CAIXAS CADASTRADAS");
                VizualizarCaixas();


                Console.WriteLine();
                Console.WriteLine("Informe o id da caixa que essa revista pertence:");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out IdCaixas))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Um número inteiro deve ser informado .");
                    Console.WriteLine();
                    Console.WriteLine("pressione ENTER para prosseguir");
                    Console.ReadLine();


                }
            }



            Console.WriteLine("informe o Título da revista");
            string Titulo = Console.ReadLine();

            Console.WriteLine("Informe o Número da Edição da revista");
            string Entrada = Console.ReadLine();

            int NumeroEdicao;
            while (true)
            {
                if (int.TryParse(Entrada, out NumeroEdicao))
                    break;


            }

            Console.WriteLine("Informe o ano de publicação da revista (dd/mm/yyyy) ");
            DateTime AnoPublicaçao = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("-----------------------------");
            Console.WriteLine("informe o status da revista  ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1-  disponivel");
            Console.WriteLine("2-  emprestada");
            Console.WriteLine("3-  reservada");
            Console.WriteLine();

            string statusResvista = Console.ReadLine();

            if (statusResvista == "1")
            {
                statusResvista = "disponivel";
            }
            else if (statusResvista == "2")
            {
                statusResvista = "emprestada";
            }
            else
            {
                statusResvista = "reservada";
            }




            Caixa CaixaSelecionada = repositoriocaixas.SelecionarCaixasPorId(IdCaixas);

            Revista NovaRevista = new Revista(Titulo, NumeroEdicao, AnoPublicaçao, statusResvista, CaixaSelecionada);


            return NovaRevista;
        }

        public void vizualizarRevistas()
        {
            Console.WriteLine("{0, -10} | {1, -15} | {2, -10}     | {3,-15} |   {4, -15} |        {5, -15}",
                               "Id", "Título", "Nº Edição", " Ano.public", "status disp, ", " caixa");

            Console.WriteLine();

            Revista[] revistascadastradas = repositoriorevista.VizualizarRevistas();


            for (int i = 0; i < revistascadastradas.Length; i++)
            {
                if (revistascadastradas[i] == null) continue;

                else
                {
                    Revista r = revistascadastradas[i];

                    Console.WriteLine("{0, -10} | {1, -15} | {2, -10}     | {3,-15} |   {4, -15} |        {5, -15}",
                                       r.Id, r.Titulo, r.NumeroEdicao, r.AnoPublicacao.ToShortTimeString(), r.StatusEmprestimo, r.Caixa.Etiqueta);


                    Console.WriteLine();
                    break;
                }

            }
            Console.WriteLine("pressione Enter para continuar");
            Console.ReadLine();
        }
        public void EditarRevista()
        {

            vizualizarRevistas();
            Console.WriteLine();


            Console.WriteLine("informe o Id da revista que deseja editar");

            string entrada = Console.ReadLine();

            int IdRevistaEditada = 0;
            while (true)
            {
                if (int.TryParse(entrada, out IdRevistaEditada))
                    break;

                else
                {
                    Console.WriteLine("Informe um número inteiro");
                    Console.WriteLine();
                    Console.WriteLine("pressione ENTER para continuar");
                    Console.ReadLine();

                }



            }
            Revista RevistaEditada = ObterDadosRevista();



            RevistaEditada = repositoriorevista.EditarRevista(IdRevistaEditada, RevistaEditada);


        }

        public void ExcluirRevistas()
        {
            vizualizarRevistas();

            Console.WriteLine("Informe o Id da revista que deseja excluir ");
            int IdEscolhido = Convert.ToInt32(Console.ReadLine());

            repositoriorevista.ExcluirRevista(IdEscolhido);


        }


    }
}

