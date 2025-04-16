using Projeto_Clube_do_livro_2025.compartilhado;
using Projeto_Clube_do_livro_2025.ModuloAmigo;
using Projeto_Clube_do_livro_2025.ModuloCaixa;
using Projeto_Clube_do_livro_2025.ModuloEmprestimo;
using Projeto_Clube_do_livro_2025.ModuloRevista;
using System.ComponentModel.Design;

namespace Projeto_Clube_do_livro_2025;

internal class Program
{
    static void Main(string[] args)
    {
        RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
        RepositorioAmigo repositorioamigo = new RepositorioAmigo();
        RepositorioCaixa repositoriocaixa = new RepositorioCaixa();
        RepositorioRevista repositorioRevista = new RepositorioRevista();
        RepositorioEmprestimo repositorioEmprestimo1 = new RepositorioEmprestimo();


        TelaEmprestimo emprestimo = new TelaEmprestimo(repositorioamigo, repositorioRevista, repositoriocaixa,repositorioEmprestimo);
        TelaAmigo amigos = new TelaAmigo(repositorioamigo, repositorioEmprestimo);
        TelaCaixas caixas = new TelaCaixas(repositoriocaixa);
        TelaRevista Revistas = new TelaRevista(repositorioRevista,repositoriocaixa);
        


        Console.WriteLine("alguma coisa");

        Console.WriteLine("---------------");
        Console.WriteLine("Clube Do Livro ");
        Console.WriteLine("---------------");

        while (true)

        {


            string opcao = TelaPrincipal.MenuTelaPrincipal();


            if (opcao == "1")
            {


                Console.Clear();
                string opcaoEscolhida = TelaAmigo.MenuTelaAmigo();

                switch (opcaoEscolhida)
                {
                    
                    case "1":
                        Console.Clear();
                        amigos.CadastrarAmigos(); break;


                    case "2":
                        Console.Clear();
                        amigos.VizualizarAmigos();
                        break;


                    case "3":
                        Console.Clear();
                        amigos.EditarAmigos();
                        break;

                    case "4":
                        Console.Clear();
                        amigos.ExcluirAmigos();
                        break;


                    case "5":
                        Console.Clear();
                        amigos.VizualizarEmprestimos();
                        break;
                }
            }

            else if (opcao == "2")
            {

                string OpcaoEscolhida = TelaCaixas.MenuTelaCaixas();

                Console.Clear();
                switch (OpcaoEscolhida)
                {


                    case "1":
                        Console.Clear();
                        caixas.CadastrarCaixas();
                        break;

                    case "2":
                        Console.Clear();
                        caixas.VizualizarCaixas();
                        break;

                    case "3":
                        Console.Clear();
                        caixas.EditarCaixas();
                        break;

                    case "4":
                        Console.Clear();
                        caixas.excluirCaixas();
                        break;

                  

                    default:

                        Console.WriteLine("saindo do programa");
                        break;
                }
            }

            else if (opcao == "3")
            {
                Console.Clear();
                string OpcaoEscolhida = TelaRevista.MenuRevista();

                switch (OpcaoEscolhida)
                {
                    case "1":
                        Console.Clear();
                        Revistas.CdastrarRevista();
                        break;

                            case "2":
                        Console.Clear();
                        Revistas.vizualizarRevistas();
                        break;


                        case "3":
                        Console.Clear();
                        Revistas.EditarRevista();
                        break;


                           case "4":
                        Console.Clear();
                        Revistas.ExcluirRevistas();
                        break; 


                }
              

            }
            else if (opcao == "4")
            {
                string opcaoEscolhida = TelaEmprestimo.MenuEmprestimo();



                switch (opcaoEscolhida)
                {

                    case "1":Console.Clear();
                        emprestimo.CadastrarEmprestimo();
                        break;



                }

            }
        }
    }
}




