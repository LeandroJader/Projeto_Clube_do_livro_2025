using Projeto_Clube_do_livro_2025.compartilhado;
using Projeto_Clube_do_livro_2025.ModuloAmigo;
using Projeto_Clube_do_livro_2025.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_Clube_do_livro_2025.ModuloCaixa
{
   public class TelaCaixas
    {
         RepositorioCaixa repositoriocaixas;
   


        public TelaCaixas(RepositorioCaixa repositoriocaixa)
            {

            this.repositoriocaixas = repositoriocaixa;
            }
            
        
        

      public static string MenuTelaCaixas()
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
            string erros = "";
            bool consegiuCadastrar = true;
            while (consegiuCadastrar == true) {

                

             Caixa Novacaixa = ObterDadosCaixas();
             erros = repositoriocaixas.ValidarACaixa(Novacaixa.Etiqueta, Novacaixa.Cor);

                if (erros.Length > 0)
                {
                    Notificador.ExibirMensagem(erros, ConsoleColor.Red);
                    continue;

                }

                else
                {

                    repositoriocaixas.CadastrarCaixas(Novacaixa);
                    Notificador.ExibirMensagem("Cadastro concluido ", ConsoleColor.Green);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("pressione ENTER para continuar");
                    consegiuCadastrar = false;
                }

            }

        }

        public Caixa ObterDadosCaixas()
        {
            Console.WriteLine("Informe a etiqueta  de edição desta caixa");
            string Etiqueta = Console.ReadLine();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("informe 1 - para etiqueta azul -    / Rara");
            Console.WriteLine("informe 2 - para etiqueta amarela  / média");
            Console.WriteLine("informe 3 - para etiqueta branca  / comum");
            Console.WriteLine("-------------------------------------------------");
            string Raridade = Console.ReadLine();


            int diasEmprestimo = 0;
            

            if (Raridade =="1")            
           
            {
                Caixa.DefinircorEtiqueta("rara", ConsoleColor.Blue);
                 diasEmprestimo = 7;
                Raridade = "rara";
            }
            if (Raridade == "2")

            {
                Caixa.DefinircorEtiqueta("média", ConsoleColor.Yellow);
                diasEmprestimo = 5;
                Raridade = "média";
            }
            if (Raridade == "3")

            {
                Caixa.DefinircorEtiqueta("comum", ConsoleColor.White);
                diasEmprestimo = 3;
                Raridade = "comum";
            }



            Console.WriteLine($"Essa edição possui {diasEmprestimo} dias de emprestimo");
            Console.WriteLine();

            Console.WriteLine("pressione ENTER para prosseguir");
            Console.ReadLine();

            Caixa NovaCaixa = new Caixa(Etiqueta,Raridade, diasEmprestimo);


            
            return NovaCaixa;

        }

        public void VizualizarCaixas()
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3,-10} ",
                                "Id", "etiqueta", "cor", "Dias de emprestimo");

            Console.WriteLine();

            Caixa[] caixascadastradas  = repositoriocaixas.VizualizarCaixas();


            for (int i = 0; i < caixascadastradas.Length; i++)
            {
                if (caixascadastradas[i] == null) continue;

                else
                {
                    Caixa a = caixascadastradas[i];

                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | ",
                                       a.Id, a.Etiqueta, a.Cor, a.DiasDeEmprestimos);
                    Console.WriteLine();
                    
                }
            }

                    Console.WriteLine("pressione Enter para prosseguir ");
                    Console.ReadLine();
        }

        public void EditarCaixas()
        {
            VizualizarCaixas();



            string erros = "";
            bool consegiuCadastrar = true;
            while (consegiuCadastrar == true)
            {



                Caixa CaixaEditada = ObterDadosCaixas();
                erros = repositoriocaixas.ValidarACaixa(CaixaEditada.Etiqueta,CaixaEditada.Cor);

                if (erros.Length > 0)
                {
                    Notificador.ExibirMensagem(erros, ConsoleColor.Red);
                    continue;

                }

                else
                {

                    repositoriocaixas.CadastrarCaixas(CaixaEditada);
                    Notificador.ExibirMensagem("Cadastro concluido ", ConsoleColor.Green);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("pressione ENTER para continuar");
                    consegiuCadastrar = false;
                }

            }






           




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
