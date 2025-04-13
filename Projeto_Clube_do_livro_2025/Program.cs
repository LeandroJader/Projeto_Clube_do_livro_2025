using Projeto_Clube_do_livro_2025.ModuloAmigo;

namespace Projeto_Clube_do_livro_2025;

    internal class Program
    {
        static void Main(string[] args)
        {
            TelaAmigo amigos = new TelaAmigo();
            TelaCaixas caixas = new TelaCaixas();
            

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
                    }
                }

                else if (opcao == "2")
                {

                    string OpcaoEscolhida = TelaCaixas.MenuTelaCixas();

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


                        default:

                            Console.WriteLine("saindo do programa");
                            break;
                    }
                }

                }
            }
        }


    

