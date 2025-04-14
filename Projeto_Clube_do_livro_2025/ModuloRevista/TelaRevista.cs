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
        public TelaRevista()
        {
            repositoriocaixas = new RepositorioCaixa();
            repositoriorevista = new RepositorioRevista();
        }
        public static string MenuRevista()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("informe a opção desejada ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("1- para cadastrar revistas");
            Console.WriteLine("2- para vizualizar revistas");
            Console.WriteLine("3- para editar revidstas");
            Console.WriteLine("4- para excluir revidstas");

            string OpcaoEscolhida = Console.ReadLine();
            return OpcaoEscolhida;

        }





        public void CadastarrRevista()
        {
            Revista NovaRevista = ObterDadosRevista();
            repositoriorevista.CadastrarRevista(NovaRevista);

        }



        public Revista ObterDadosRevista()
        {
            Console.WriteLine("informe o Título da revista");
            string Titulo = Console.ReadLine();

            Console.WriteLine("Informe o Número da Edição da revista");
            int NumeroEdicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o ano de publicação da revista (dd/mm/yyyy) ");
            DateTime AnoPublicaçao = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("informe o status da revista ");
            string statusEmprestimo = Console.ReadLine();

            Console.WriteLine("Informe o id da caixa que essa revista pertence");
            int iDCaixas = Convert.ToInt32(Console.ReadLine());

            Caixa CaixaSelecionada = repositoriocaixas.SelecionarCaixasPorId(iDCaixas);

            Revista NovaRevista = new Revista(Titulo, NumeroEdicao, AnoPublicaçao, statusEmprestimo, CaixaSelecionada);

            return NovaRevista;
        }

    }
}
