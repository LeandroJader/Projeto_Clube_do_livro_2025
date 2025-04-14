using Projeto_Clube_do_livro_2025.ModuloCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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


        public void CadastarrRevista()
        {

            VizualizarCaixas();
            
            Console.WriteLine();

            Revista NovaRevista = ObterDadosRevista();
            repositoriorevista.CadastrarRevista(NovaRevista);

        }
        


        public Revista ObterDadosRevista()
        {
            Console.WriteLine("Informe o id da caixa que essa revista pertence");
            int iDCaixas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o Título da revista");
            string Titulo = Console.ReadLine();

            Console.WriteLine("Informe o Número da Edição da revista");
            int NumeroEdicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o ano de publicação da revista (dd/mm/yyyy) ");
            DateTime AnoPublicaçao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("informe o status da revista ");
            string statusEmprestimo = Console.ReadLine();

            Caixa CaixaSelecionada = repositoriocaixas.SelecionarCaixasPorId(iDCaixas);

            Revista NovaRevista = new Revista(Titulo, NumeroEdicao, AnoPublicaçao, statusEmprestimo, CaixaSelecionada);


            return NovaRevista;
        }

        public void vizualizarRevistas()
        {
            Console.WriteLine("{0, -10} | {1, -15} | {2, -10}     | {3,-15} |   {4, -15} |        {5, -15}",
                               "Id",      "Título", "Nº Edição", " Ano.public", "status disp, ",  " caixa");

            Console.WriteLine();

            Revista[] revistascadastradas = repositoriorevista.VizualizarRevistas();


            for (int i = 0; i < revistascadastradas.Length; i++)
            {
                if (revistascadastradas[i] == null) continue;

                else
                {
                    Revista r = revistascadastradas[i];

                    Console.WriteLine("{0, -10} | {1, -15} | {2, -10}     | {3,-15} |   {4, -15} |        {5, -15}",
                                       r.Id, r.Titulo,r.NumeroEdicao, r.AnoPublicacao.ToShortDateString(), r.StatusEmprestimo, r.Caixa.Etiqueta);


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
            int IdrevistaEditada = Convert.ToInt32(Console.ReadLine());

            Revista RevistaEditada = ObterDadosRevista();   

            

            RevistaEditada = repositoriorevista.EditarRevista(IdrevistaEditada ,RevistaEditada);


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
