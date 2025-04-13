
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

    internal void VizualizarAmigos()
    {

        Console.WriteLine("vizualizando amigos ");
        Console.WriteLine();

        Console.WriteLine("{0, -10} | {1, -15} | {2,-20} |  {3,-15} ",
                             "Id", "nome", "nome responsavel", "telefone"
                  );
        Console.WriteLine();

        Amigo[] amigosCadastrados = repositorioamigo.selecionarFabricantes();

        for (int i = 0; i < amigosCadastrados.Length; i++)
        {
            Amigo a = amigosCadastrados[i];

            if (a == null) continue;

            else
            {

                Console.WriteLine("{0, -10} | {1, -15} | {2,-20} |  {3,-15} ",
                                a.Id, a.Nome, a.NomeResponsavel, a.Telefone
                     );

            }
        }
        Console.ReadLine();
    }
}

