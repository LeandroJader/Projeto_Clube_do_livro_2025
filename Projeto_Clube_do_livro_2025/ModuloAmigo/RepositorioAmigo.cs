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

        public Amigo[] SelecionarAmigos()
        {
            return AmigosCadastrados;
        }

       
       public bool EditarAmigos(int idAmigoEscolhido, Amigo amigoEditado)
        {
            for (int i = 0; i <AmigosCadastrados.Length ;  i++)
            {
                if (AmigosCadastrados[i].Id == null) continue;

                else if (AmigosCadastrados[i].Id == idAmigoEscolhido)
                {
                    AmigosCadastrados[i].Nome = amigoEditado.Nome;
                    AmigosCadastrados[i].NomeResponsavel = amigoEditado.NomeResponsavel;
                    AmigosCadastrados[i].Telefone = amigoEditado.Telefone;
                    break;

                }


            }



            return true;
        }

        public bool ExcluirAmigos (int Idescolhido)
        {
          for (int i=0; i<AmigosCadastrados.Length; i++)
            {
                if (AmigosCadastrados[i].Id == null) continue;

                else if (AmigosCadastrados[i].Id == Idescolhido)
                {
                    Console.WriteLine("amigo excluido com sucesso");
                    AmigosCadastrados[i] = null;
                    break;
                }
            }
                return true;
        }
    }
}
