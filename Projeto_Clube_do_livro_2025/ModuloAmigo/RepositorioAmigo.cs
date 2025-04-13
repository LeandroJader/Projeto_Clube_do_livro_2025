using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloAmigo
{
    public class RepositorioAmigo
    {
        public Amigo[] AmigosCadastrados = new Amigo[100];
        public int ContadorAmigos = 0;
        public void CadastrarAmigo(Amigo NovoAmigo)

        {
            NovoAmigo.Id = GeradorId.GerarIdAmigo();
            AmigosCadastrados[ContadorAmigos++] = NovoAmigo;


        }

        public Amigo[] selecionarFabricantes()
        {
            return AmigosCadastrados;
        }
    }
}
