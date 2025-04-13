namespace Projeto_Clube_do_livro_2025.ModuloAmigo
{
    public class Amigo
    {
        public int Id;
        public string Nome;
        public string NomeCompleto;
        public string Telefone;

        public Amigo(string nome, string nomeCompleto, string telefone)
        {
            Nome = nome;
            NomeCompleto = nomeCompleto;
            Telefone = telefone;
        }
    }
}
