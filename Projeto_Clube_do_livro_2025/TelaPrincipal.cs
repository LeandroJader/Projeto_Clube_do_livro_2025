using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
{
   public static class TelaPrincipal
    {
        public static string  MenuTelaPrincipal()
        {
            Console.Clear();
            Console.WriteLine("------------------------ ");
            Console.WriteLine("bem vindo a sua livraria ");
            Console.WriteLine("------------------------ ");
            Console.WriteLine();
            Console.WriteLine("informe opção que deseja");
            Console.WriteLine("1- menu amigos ");
            Console.WriteLine("2- menu caixas");

            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;

        }



    }
}
