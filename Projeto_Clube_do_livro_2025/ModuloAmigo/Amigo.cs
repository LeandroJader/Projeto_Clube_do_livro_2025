namespace Projeto_Clube_do_livro_2025.ModuloAmigo
{
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
    }
}
