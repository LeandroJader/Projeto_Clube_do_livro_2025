using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
{
    class RepositorioCaixa
    {
        public Caixa [] caixasCadastradas = new Caixa [100];
        public int contadorCaixa = 0;


        public void CadastrarCaixas(Caixa NovaCaixa)
        {
            caixasCadastradas[contadorCaixa++] = NovaCaixa;

           
        }
        public Caixa [] VizualizarCaixas()
        {

            return caixasCadastradas;

        }


    }
}
