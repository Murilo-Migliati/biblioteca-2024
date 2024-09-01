using biblioteca_2024.Data;
using biblioteca_2024.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using biblioteca_2024;

namespace biblioteca_2024
{
    public class Program
{
    public static void Main(string[] args)
    {
            //MostrarLivros();
            DALbiblioteca.InserLivros();
        
     }
        public static void MostrarLivros()
        {
            //para exibir os resultados da consulta SQL
            List<Livro> Livros = DALbiblioteca.GetLivros();
            foreach (Livro Livro in Livros)
            {
                //Console.WriteLine("Id: {0}", Livro.Id);
                Console.WriteLine("Autor: {0}", Livro.Autor); //forma padrão por índice
                //Console.WriteLine("ID: " + livro.Id); // concatenação
                //Console.Writeline($"ID: {livro.Id}"); //string interpolada
                Console.WriteLine("Título: {0}", Livro.Titulo);
                Console.WriteLine("Ano de Publicação: " + Livro.anoPublicacao);
                Console.WriteLine();
            }
            
        }

    }
}