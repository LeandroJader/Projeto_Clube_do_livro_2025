

namespace Projeto_Clube_do_livro_2025.ModuloAmigo;

public class TelaAmigo
{


    public RepositorioAmigo repositorioamigo;
    public TelaAmigo(RepositorioAmigo repositorioamigo)
    {
        this.repositorioamigo = repositorioamigo;

    }

    public static string MenuTelaAmigo()
    {
        Console.WriteLine("escolha a opção desejada");
        Console.WriteLine("---------------");
        Console.WriteLine("1 - cadastrar amigo");
        Console.WriteLine("2- vizualizar amigos cadastrados");
        Console.WriteLine("3- editar amigos");
        Console.WriteLine("4- excluir amigos");

        string OpcaoEscolhida = Console.ReadLine();
        return OpcaoEscolhida;
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

    public void VizualizarAmigos()
    {

        Console.WriteLine("vizualizando amigos ");
        Console.WriteLine();

        Console.WriteLine("{0, -10} | {1, -15} | {2,-20} |  {3,-15} ",
                             "Id", "nome", "nome responsavel", "telefone"
                  );
        Console.WriteLine();

        Amigo[] amigosCadastrados = repositorioamigo.SelecionarAmigos();

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
        Console.WriteLine("Aperte ENTER para continuar");
        Console.ReadLine();
    }
  

    public void EditarAmigos()
    {
        VizualizarAmigos();
            
        Console.WriteLine("informe o id do amigo que deseja editar");

        int IdAmigoEscolhido = Convert.ToInt32(Console.ReadLine());


        Amigo amigoEditado = ObterDadosAmigos();
       bool Consegiueditar = repositorioamigo.EditarAmigos(IdAmigoEscolhido,amigoEditado);

    }

    public void ExcluirAmigos()
    {
        VizualizarAmigos();


        Console.WriteLine("informe o Id do amigo que deseja excluir ");
        int IdEscolhido = Convert.ToInt32(Console.ReadLine());

       bool consegiuExcluir = repositorioamigo.ExcluirAmigos(IdEscolhido);



    }
       


}

