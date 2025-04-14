using Projeto_Clube_do_livro_2025.ModuloAmigo;
using Projeto_Clube_do_livro_2025.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
{
    class GeradorId
    {
        public static int IdCaixa = 0;
        public static int Idamigo = 0;
        public static int IdRevista = 0;
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

        public static int GerarIdRevista()
        {
            IdRevista++;

            return IdRevista;
        }
    }
}
