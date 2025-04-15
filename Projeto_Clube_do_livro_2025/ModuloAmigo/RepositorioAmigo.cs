using Projeto_Clube_do_livro_2025.compartilhado;
using Projeto_Clube_do_livro_2025.ModuloCaixa;
using Projeto_Clube_do_livro_2025.ModuloEmprestimo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Clube_do_livro_2025.ModuloAmigo
{
    public class RepositorioAmigo
    {
        public Amigo[] AmigosCadastrados = new Amigo[100];
        public int ContadorAmigos = 0;
        public void CadastrarAmigo(Amigo NovoAmigo)

        {
            NovoAmigo.Id = GeradorId.GerarIdAmigo();
            AmigosCadastrados[ContadorAmigos++] = NovoAmigo;


        }

        public Amigo[] SelecionarAmigos()
        {
            return AmigosCadastrados;
        }
        public Amigo SelecionarAmigoPorId(int IdSelecionado)
        {


            for (int i = 0; i < AmigosCadastrados.Length; i++)
            {
                if (AmigosCadastrados[i].Id == null) continue;

                else if (AmigosCadastrados[i].Id == IdSelecionado)
                {
                    return AmigosCadastrados[i];

                }
            }

            return null;

        }


        public bool EditarAmigos(int idAmigoEscolhido, Amigo amigoEditado)
        {
            for (int i = 0; i < AmigosCadastrados.Length; i++)
            {
                if (AmigosCadastrados[i].Id == null) continue;

                else if (AmigosCadastrados[i].Id == idAmigoEscolhido)
                {
                    AmigosCadastrados[i].Nome = amigoEditado.Nome;
                    AmigosCadastrados[i].NomeResponsavel = amigoEditado.NomeResponsavel;
                    AmigosCadastrados[i].Telefone = amigoEditado.Telefone;
                    break;

                }


            }



            return true;
        }

        public bool ExcluirAmigos(int Idescolhido)
        {

     
            for (int i = 0; i < AmigosCadastrados.Length; i++)
            {
                if (AmigosCadastrados[i].Id == null) continue;

                else if (AmigosCadastrados[i].Id == Idescolhido)
                {
                    Notificador.ExibirMensagem("Amigo Excluido com sucesso", ConsoleColor.Green);
                    AmigosCadastrados[i] = null;
                    break;
                }
            }
            return true;
        }
        public string ValidarAmigos(string nome, string NomeResponsavel ,string Telefone)
        {
            

            string erros = "";

            for (int i = 0; i < AmigosCadastrados.Length; i++)
            {
                if ( AmigosCadastrados[i] != null && nome == AmigosCadastrados[i].Nome )
                    erros += "nao pode existir nomes duplicados escolha outro nome ";
                break;
           }
                   

            if (string.IsNullOrWhiteSpace(nome) && nome.Length < 3)
                erros += "O campo Nome É Obrigatorio e deve conter ao menos três caracteres \n ";


            for (int i = 0; i < AmigosCadastrados.Length; i++)
            {
                if (AmigosCadastrados[i] != null && NomeResponsavel == AmigosCadastrados[i].NomeResponsavel)
                    erros += "nao pode existir nomes responsáveis duplicados escolha outro nome ";
                break;
            }


            if (string.IsNullOrWhiteSpace(NomeResponsavel) && NomeResponsavel.Length < 3)
                erros += "O campo Nome responsável nao pode ser nulo e deve conter ao menos três caracteres \n";


            if (string.IsNullOrWhiteSpace(Telefone) && Telefone.Length < 13)
                erros += "O campo telefone nao pode ser nulo ! E deve ser no formato do Exemplo... Ex: 00 123456789\n";



            return erros;
        }

           
        }
    }

