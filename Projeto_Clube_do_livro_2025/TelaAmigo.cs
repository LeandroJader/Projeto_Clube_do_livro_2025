
namespace Projeto_Clube_do_livro_2025
{
    public class TelaAmigo
    {






        public void ObterDadosAmigos()
        {
            Console.WriteLine("informe o nome completo do amigo");
            string nome = Console.ReadLine();

            Console.WriteLine("informe o nome completo do responsável ");
            string nomeCompletoResponsavel = Console.ReadLine();

            Console.WriteLine("informe o telefone ");
            string telefone = Console.ReadLine();

            Amigo NovoAmigo = new Amigo(nome, nomeCompletoResponsavel, telefone);
        }




    }
}
