using Projeto_Clube_do_livro_2025.ModuloAmigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
{
    class GeradorId
    {
        public static int IdCaixa;
        public static int Idamigo = 0;
 
        public static int GerarIdAmigo()
        {

            Idamigo++;

            return Idamigo;
             
        }
        public static int GerarIdCaixa()
        {
            IdCaixa++;
            return IdCaixa;

        }


    }
}
