using Projeto_Clube_do_livro_2025.ModuloEmprestimo;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_Clube_do_livro_2025.ModuloAmigo;

public class Amigo
{
    public int Id;
    public string Nome;
    public string NomeResponsavel;
    public string Telefone;

    public Amigo(string nome, string nomeResponsavel, string telefone)
    {
        Nome = nome;
        NomeResponsavel = nomeResponsavel;
        Telefone = telefone;
    }

    public string ValidarAmigo()
    {
        string erros = "";

        if (string.IsNullOrWhiteSpace(Nome) && Nome.Length < 3)
            erros += "O campo Nome É Obrigatorio e deve conter ao menos três caracteres \n ";


        if (string.IsNullOrWhiteSpace(NomeResponsavel) && NomeResponsavel.Length < 3)
            erros += "O campo Nome responsável nao pode ser nulo e deve conter ao menos três caracteres \n";


        if (string.IsNullOrWhiteSpace(Telefone) && Telefone.Length<13)
            erros += "O campo telefone nao pode ser nulo ! E deve ser no formato do Exemplo... Ex: 00 123456789\n";

       

        return erros;
    }








}



