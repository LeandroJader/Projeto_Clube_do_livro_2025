using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025
{
    public class Caixa
    {
        public string Etiqueta;
        public string Cor;
        public DateTime DiasEmprestados;

        public Caixa(string etiqueta, string cor)
        {
            Etiqueta = etiqueta;
            Cor = cor;
            DiasEmprestados = DateTime.Now;
        }


    }
}
