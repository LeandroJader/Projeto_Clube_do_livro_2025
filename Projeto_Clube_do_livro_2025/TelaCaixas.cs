using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
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
            Console.WriteLine("-------------------------");
            Console.WriteLine("informe a Opçõo Escolhida");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1- cadastrar caixas");
            Console.WriteLine("2- vizualiza caixas cadastradas");

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
            Console.WriteLine("Informe a etiqueta da caixa");
            string etiqueta = Console.ReadLine();

            Console.WriteLine("informe a cor da Etiqueta");
            string Cor = Console.ReadLine();

            Caixa NovaCaixa = new Caixa(etiqueta, Cor);

            return NovaCaixa;

        }

        public void VizualizarCaixas()
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10}",
                                "etiqueta", "cor", "Data. emprestiimo ");

            Console.WriteLine();

            Caixa[] caixascadastradas  = repositoriocaixas.VizualizarCaixas();


            for (int i = 0; i<caixascadastradas.Length; i++)
            {
                Caixa a = caixascadastradas[i];

                Console.WriteLine("{0, -10} | {1, -10} | {2, -10}",
                                    a.Etiqueta,a.Cor ,a.DiasEmprestados);
                break;
            }
        }


    }
}
