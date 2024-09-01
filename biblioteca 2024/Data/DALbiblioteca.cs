using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_2024.Model;
using System.Data.SqlClient;
using biblioteca_2024;

namespace biblioteca_2024.Data
{
    public class DALbiblioteca
    {
        /*  1 - conexão com o BD, encontrar onde está o arquivo de banco de dados criar um metodo que faz a conexão
            2 - criar um metodo que faz aconsulta com o bd este metodo faz parte da classe DAL que tambem é chamado no Program.cs fazer primeiro com DataTable(tipo de objeto para exibir dados e depois numa lista
            3 - exibir os resultados que vieram da consulta e receber os resultados de alguma forma e formatar os resultados e dar print na tela*/
        //propriedade de conexão com BD
        private static SQLiteConnection sQLiteConnection;
        public static string path = Directory.GetCurrentDirectory() + "\\biblioteca.db";
        //public static string path = Directory.GetCurrentDirectory() + "//dbpai.db";
        //"C:\Users\muril\source\repos\biblioteca 2024\dbpai.db";
        private static SQLiteConnection DbConnection()
        {
            sQLiteConnection = new SQLiteConnection("DataSource=" + path);
            sQLiteConnection.Open();
            return sQLiteConnection;
        }
        public static List<Livro> GetLivros()
        {
            List<Livro> Livros = new List<Livro>();
            //Try Catch pq estamos trabalhando com banco de dados
            try
            {
                //criando um contexto para executar um comando de BD
                using (var comando = DbConnection().CreateCommand())
                {
                    //definido comando SQL que vai ser executado
                    comando.CommandText = "SELECT * FROM Livros";
                    //acessando cada linha da tabela
                    //loop para enquanto estiver coisa para ler
                    using (var Leitor = comando.ExecuteReader())
                    {
                        while (Leitor.Read())
                        {
                            //enquanto tiver livros para ler, vamos criar um objeto livro
                            Livro livros = new Livro(Leitor["titulo"].ToString(),
                                                    Leitor["autor"].ToString(),
                                                    Convert.ToInt32(Leitor["anoPublicacao"]));
                            Livros.Add(livros);
                        }
                
                    }
                }
                return Livros;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine($"Erro ao realizar consulta {e.Message}");
                throw;
            }
            catch (Exception e1)
            {
                Console.WriteLine($"Erro Generico {e1.Message}");
                throw;
            }
            }
            public static void InserLivros()
            {
            try
            {
                //fazer leitura dos dados que vão ser inseridos

                Console.WriteLine("Digite o Id do Livro:");
                int id = Convert.ToInt32(Console.ReadLine());
                //int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o autor do Livro:");
                string autor = Console.ReadLine();
                Console.WriteLine("Digite o titulo do Livro:");
                string titulo = Console.ReadLine();
                Console.WriteLine("Digite o ano da publicacao do Livro:");
                int anoPub = Convert.ToInt32(Console.ReadLine());
                //criando o contexto de conexao com o BD
                using (var comando = DbConnection().CreateCommand()) {
                    comando.CommandText = "INSERT INTO Livros(idLivro,titulo,anoPublicacao,autor) VALUES(@id,@titulo,@anoPub,@autor)";
                    //atribuir valores para os parametros insert
                    comando.Parameters.AddWithValue("@id",id);
                    comando.Parameters.AddWithValue("@titulo", titulo);
                    comando.Parameters.AddWithValue("@autor", autor);
                    comando.Parameters.AddWithValue("@anoPub", anoPub);
                    //executar o comando
                    comando.ExecuteNonQuery();
                }
                    //Sucesso
                    Console.WriteLine("DEU CERTO P###");

            }
            catch (SQLiteException e)
            {
                Console.WriteLine($"Erro ao realizar consulta {e.Message}");
                throw;
            }
            catch (Exception e1)
            {
                Console.WriteLine($"Erro Generico {e1.Message}");
                throw;
            }
        }

    }
}
