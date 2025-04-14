using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloCaixa
{
   public class TelaCaixas
    {
         RepositorioCaixa repositoriocaixas;
        
        public TelaCaixas()
            {
            repositoriocaixas = new RepositorioCaixa();

            }
            
        
        

      public static string MenuTelaCixas()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("informe a Opçõo Escolhida");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1- cadastrar caixas");
            Console.WriteLine("2- vizualizar caixas cadastradas");
            Console.WriteLine("3- editar caixas cadastradas");
            Console.WriteLine("4- excluir caixas cadastradas");

            string OpcaoEscolhida = Console.ReadLine();
            return OpcaoEscolhida;
        }


        public void CadastrarCaixas()
        {
            Caixa Novacaixa = ObterDadosCaixas();

            repositoriocaixas.CadastrarCaixas(Novacaixa);

        }

        public Caixa ObterDadosCaixas()
        {
            Console.WriteLine("Informe a etiqueta  de edição desta caixa");
            string etiqueta = Console.ReadLine();

            Console.WriteLine("informe a cor da Etiqueta");
            string Cor = Console.ReadLine();

            Console.WriteLine("informe quantos dias de emprestimo essa edição possui");
            int DiasDeEmpestimo = Convert.ToInt32(Console.ReadLine());

            Caixa NovaCaixa = new Caixa(etiqueta, Cor, DiasDeEmpestimo);

            return NovaCaixa;

        }

        public void VizualizarCaixas()
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3,-10}",
                                "Id", "etiqueta", "cor", "Dias de emprestimo" );

            Console.WriteLine();

            Caixa[] caixascadastradas  = repositoriocaixas.VizualizarCaixas();


            for (int i = 0; i < caixascadastradas.Length; i++)
            {
                if (caixascadastradas[i].Id == null) break;

                else
                {
                    Caixa a = caixascadastradas[i];

                    Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10}",
                                       a.Id, a.Etiqueta, a.Cor, a.DiasDeEmprestimos);
                    Console.WriteLine();
                    break;
                }
            }

                    Console.WriteLine("pressione Enter para prosseguir ");
                    Console.ReadLine();
        }

        public void EditarCaixas()
        {
            VizualizarCaixas();
            Console.WriteLine();
            Console.WriteLine("informe o Id da caixa que deseja Editar");
            int IdEscolhido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira a nova etiqueta de edição da caixa");
            string etiqueta = Console.ReadLine();

            Console.WriteLine("informe a cor da etiqueta");
            string cor = Console.ReadLine();

            Console.WriteLine("informe quantos dias de emprestimo essa edição possui ");
            int DiasDeEmprestimo=Convert.ToInt32(Console.ReadLine());

            Caixa NovaCaixaEditada = new Caixa(etiqueta, cor, DiasDeEmprestimo);

            NovaCaixaEditada = repositoriocaixas.EditarCaixas(IdEscolhido,NovaCaixaEditada);

        }
        public void excluirCaixas()
        {
            VizualizarCaixas();
            Console.WriteLine();
            Console.WriteLine("Informe o Id que gostaria da caixa que gostaria de excluir");
            int IdCaixa = Convert.ToInt32(Console.ReadLine());

            repositoriocaixas.ExcluirCaixas(IdCaixa);
            Console.WriteLine("pressione Enter para continuar");
            Console.ReadLine();
        }


    }
}
