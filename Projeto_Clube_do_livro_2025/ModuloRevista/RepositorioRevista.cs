using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloRevista
{
  public  class RepositorioRevista
    {
        public Revista[] RevistasCadastradas = new Revista[100];
        public int contadorRevista;

        public void CadastrarRevista(Revista NovaRevista)
        {
            NovaRevista.Id = GeradorId.GerarIdRevista();
            RevistasCadastradas[contadorRevista++] = NovaRevista;

        }
       
    }
}
