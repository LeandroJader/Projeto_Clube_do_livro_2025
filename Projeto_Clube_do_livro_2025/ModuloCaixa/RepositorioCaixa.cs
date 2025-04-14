using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloCaixa
{
    class RepositorioCaixa
    {
        public Caixa[] caixasCadastradas = new Caixa[100];
        public int contadorCaixa = 0;


        public void CadastrarCaixas(Caixa NovaCaixa)
        {
            NovaCaixa.Id = GeradorId.GerarIdCaixa();
            caixasCadastradas[contadorCaixa++] = NovaCaixa;


        }
        public Caixa[] VizualizarCaixas()
        {

            return caixasCadastradas;

        }
        public Caixa EditarCaixas(int Idcaixa, Caixa caixaEditada)
        {
            for (int i = 0; i < caixasCadastradas.Length; i++)
            {
                if (Idcaixa == null) continue;

                else if (Idcaixa == caixasCadastradas[i].Id)
                {
                    caixasCadastradas[i].Etiqueta = caixaEditada.Etiqueta;
                    caixasCadastradas[i].Cor = caixaEditada.Cor;
                    caixasCadastradas[i].DiasDeEmprestimos = caixaEditada.DiasDeEmprestimos;
                   

                    break;
                }
            }
                return caixaEditada;

            

        }
        public void ExcluirCaixas(int IdCaixa)
        {
            for (int i =0; i<caixasCadastradas.Length; i++)
            {
                if (caixasCadastradas[i].Id == null) continue;

                else if (caixasCadastradas[i].Id == IdCaixa)
                {

                    caixasCadastradas[i] = null;
                    Console.WriteLine("caixa excluida com sucesso");
                    break;
                }
            }
            


        }
    }
}
