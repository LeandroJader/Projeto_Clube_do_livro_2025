using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public Revista [] VizualizarRevistas()
        {
            return RevistasCadastradas;
                
              

        }
        public Revista EditarRevista(int IdrevistaEditada , Revista RevistaEditada)
        {
            for (int i = 0; i < RevistasCadastradas.Length; i++)
            
            {
                if (IdrevistaEditada == null) continue;

               else if (IdrevistaEditada == RevistasCadastradas[i].Id)
                {
                    RevistasCadastradas[i].Titulo = RevistaEditada.Titulo;
                    RevistasCadastradas[i].NumeroEdicao = RevistaEditada.NumeroEdicao;
                    RevistasCadastradas[i].AnoPublicacao = RevistaEditada.AnoPublicacao;
                    RevistasCadastradas[i].StatusEmprestimo = RevistaEditada.StatusEmprestimo;
                    RevistasCadastradas[i].Caixa = RevistaEditada.Caixa;
                    break;

                }

            }
                return RevistaEditada;

            


        }
        public void ExcluirRevista(int IdRevista)
        {
            for (int i = 0; i <RevistasCadastradas.Length; i++)
            {

                if (IdRevista == null) continue;

                else if (RevistasCadastradas[i].Id == IdRevista)
                {

                    Console.WriteLine("revista excluida");
                    RevistasCadastradas[i] = null;
                    break;
                }

            }
            Console.WriteLine("pressione Enter para Continuar ");
            Console.ReadLine();



        }



       
    }
}
