

using Projeto_Clube_do_livro_2025.compartilhado;
using Projeto_Clube_do_livro_2025.ModuloCaixa;
using Projeto_Clube_do_livro_2025.ModuloEmprestimo;

namespace Projeto_Clube_do_livro_2025.ModuloAmigo;

public class TelaAmigo
{

    public RepositorioEmprestimo Repositorioemprestimo;
    public RepositorioAmigo Repositorioamigo;



    public TelaAmigo(RepositorioAmigo repositorioamigo, RepositorioEmprestimo repositorioEmprestimo)
    {
        this.Repositorioamigo = repositorioamigo;
        this.Repositorioemprestimo = repositorioEmprestimo;

    }

    public static string MenuTelaAmigo()
    {
        Console.WriteLine("escolha a opção desejada");
        Console.WriteLine("---------------");
        Console.WriteLine("1 - cadastrar amigo");
        Console.WriteLine("2- vizualizar amigos cadastrados");
        Console.WriteLine("3- editar amigos");
        Console.WriteLine("4- excluir amigos");
        Console.WriteLine("5- Exibir Emprestimos de amigos");

        string OpcaoEscolhida = Console.ReadLine();
        return OpcaoEscolhida;
    }


    public Amigo ObterDadosAmigos()
    {
        Console.WriteLine("informe o nome completo do amigo");
        string nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("informe o nome completo do responsável ");
        string nomeCompletoResponsavel = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("informe o telefone ");
        string telefone = Console.ReadLine();
        Console.WriteLine();


        Amigo NovoAmigo = new Amigo(nome, nomeCompletoResponsavel, telefone);

        return NovoAmigo;
    }


    public void CadastrarAmigos()
    {
            bool consegiuEditar = true;
        while (consegiuEditar == true)
        {
            Console.Clear();
            Amigo NovoAmigo = ObterDadosAmigos();
            string erros = Repositorioamigo.ValidarAmigos(NovoAmigo.Nome, NovoAmigo.NomeResponsavel, NovoAmigo.Telefone);
          

            if (erros.Length > 0)
            {
                Notificador.ExibirMensagem(erros, ConsoleColor.Red);
                Console.WriteLine();
                Console.WriteLine("pressione ENTER para prosseguir");
                Console.ReadLine();
                continue;

            }

            else
            {

                Repositorioamigo.CadastrarAmigo(NovoAmigo);
                Notificador.ExibirMensagem("Cadastro concluido ", ConsoleColor.Green);               
                consegiuEditar = false;
            }
        }
    }


    public void VizualizarAmigos()
    {

        Console.WriteLine("vizualizando amigos ");
        Console.WriteLine();

        Console.WriteLine("{0, -10} | {1, -15} | {2,-20} |  {3,-15} ",
                             "Id", "nome", "nome responsavel", "telefone"
                  );
        Console.WriteLine();
        Console.WriteLine();

        Amigo[] amigosCadastrados = Repositorioamigo.SelecionarAmigos();

        for (int i = 0; i < amigosCadastrados.Length; i++)
        {
            Amigo a = amigosCadastrados[i];

            if (a == null) continue;

            else
            {
                Console.WriteLine("-----------------------------------------------------");
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



        while (true)
        {
            Amigo amigoEditado = ObterDadosAmigos();
            string erros = Repositorioamigo.ValidarAmigos(amigoEditado.Nome, amigoEditado.NomeResponsavel, amigoEditado.Telefone);


            if (erros.Length > 0)
            {
                Notificador.ExibirMensagem(erros, ConsoleColor.Red);
                continue;
            }

            else if (erros.Length <= 0)
            {

                bool Consegiueditar = Repositorioamigo.EditarAmigos(IdAmigoEscolhido, amigoEditado);
                return;
            }
        }
    }

    public void ExcluirAmigos()
    {
        VizualizarAmigos();


        Console.WriteLine("informe o Id do amigo que deseja excluir ");
        int IdEscolhido = Convert.ToInt32(Console.ReadLine());

        Emprestimo[] emprestimos = Repositorioemprestimo.EmprestimosCadastrados;

        for (int i = 0; i < emprestimos.Length; i++)
        {

            if (emprestimos[i] == null)

            {
                bool consegiuExcluir = Repositorioamigo.ExcluirAmigos(IdEscolhido);
                Console.WriteLine("amigo excluido com sucesso");
            }

            else
            {
                Notificador.ExibirMensagem("este amigo nao pode ser excluido pois possui emprestimo pendente", ConsoleColor.Red);
                return;
            }

        }
    }


    
    public void VizualizarEmprestimos()
    {


        Console.WriteLine("Informe o Id do Amigo que deseja vizualizar os emprestimos");
        string entrada = Console.ReadLine();

        int IdAmigo;
        while (true)
        {
            if (int.TryParse(entrada, out IdAmigo))

                break;
        else
        {

            Console.WriteLine("Informe um número inteiro");
        }
        }

            Amigo AmigoSelecionado = Repositorioamigo.SelecionarAmigoPorId(IdAmigo);

        Console.WriteLine("{0, -10} | {1, -10} | {2, -20} | {3, -15} ",
                          "Nome.amigo", "revista ", "data", "Dias de emprestimo");
        Console.WriteLine();

        Emprestimo[] emprestimos = Repositorioemprestimo.VizualizarEmprestimo();


        for (int i = 0; i < emprestimos.Length; i++)
        {
            if (emprestimos[i] == null) continue;


            else
            {
                Emprestimo e = emprestimos[i];

                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -15} ",
                                   e.Amigo.Nome, e.Revista.Titulo, e.Data.ToShortTimeString, e.Situacao);
                Console.WriteLine();

            }
        }

        Console.WriteLine("pressione Enter para Continuar ");
        Console.ReadLine();
    }


}



