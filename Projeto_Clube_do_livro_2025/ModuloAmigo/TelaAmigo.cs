namespace Projeto_Clube_do_livro_2025.ModuloAmigo;

public class TelaAmigo
{

    public RepositorioAmigo repositorioamigo;
    public TelaAmigo()
    {
        repositorioamigo = new RepositorioAmigo();

    }



    public Amigo ObterDadosAmigos()
    {
        Console.WriteLine("informe o nome completo do amigo");
        string nome = Console.ReadLine();

        Console.WriteLine("informe o nome completo do responsável ");
        string nomeCompletoResponsavel = Console.ReadLine();

        Console.WriteLine("informe o telefone ");
        string telefone = Console.ReadLine();

        Amigo NovoAmigo = new Amigo(nome, nomeCompletoResponsavel, telefone);

        return NovoAmigo;
    }


    public void CadastrarAmigos()
    {

        Amigo NovoAmigo = ObterDadosAmigos();
        repositorioamigo.CadastrarAmigo(NovoAmigo);
    }

}

