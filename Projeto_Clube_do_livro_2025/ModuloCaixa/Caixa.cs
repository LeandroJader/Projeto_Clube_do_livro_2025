using Projeto_Clube_do_livro_2025.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloCaixa
{
    public class Caixa
    {
        public int Id;
        public string Etiqueta;
        public string Cor;
        public int DiasDeEmprestimos;
        public Revista[] Revistas; 

        public Caixa(string etiqueta, string cor, int diasEmprestados)
        {
            
            Etiqueta = etiqueta;
            Cor = cor;
            DiasDeEmprestimos = diasEmprestados;
            Revistas = new Revista[100];
        }
     
    }
 


    }

