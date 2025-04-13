using Projeto_Clube_do_livro_2025.ModuloAmigo;

namespace Projeto_Clube_do_livro_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaAmigo amigos = new TelaAmigo();



            Console.WriteLine("---------------");
            Console.WriteLine("Clube Do Livro ");
            Console.WriteLine("---------------");

            while (true)
            {
                TelaAmigo.ExibirMenuTelaAmigo();

                string opcaoEscolhida = Console.ReadLine();


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


                    default:

                        Console.WriteLine("saindo do programa");
                        break;

                }
            }
        }


    }
}
