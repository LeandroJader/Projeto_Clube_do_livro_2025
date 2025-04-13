namespace Projeto_Clube_do_livro_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaAmigo CadastrarAmigo = new TelaAmigo();

            Console.WriteLine("---------------");
            Console.WriteLine("Clube Do Livro ");
            Console.WriteLine("---------------");

            Console.WriteLine("escolha a opção desejada");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - cadastrar amigo");

            string opcaoEscolhida = Console.ReadLine();

            switch (opcaoEscolhida)
            {
               
                case "1" : Console.Clear();
                    CadastrarAmigo.ObterDadosAmigos(); break;

                   
                default: Console.WriteLine("saindo do programa");
                        break;

            }
        }
    }
}
