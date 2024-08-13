using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_2024
{
    public class DALbiblioteca
    {
        /*  1 - conexão com o BD, encontrar onde está o arquivo de banco de dados criar um metodo que faz a conexão
            2 - criar um metodo que faz aconsulta com o bd este metodo faz parte da classe DAL que tambem é chamado no Program.cs fazer primeiro com DataTable(tipo de objeto para exibir dados e depois numa lista
            3 - exibir os resultados que vieram da consulta e receber os resultados de alguma forma e formatar os resultados e dar print na tela*/
        //propriedade de conexão com BD
        private static SQLiteConnection sQLiteConnection;
        public static string path = Directory.GetCurrentDirectory() + "//dbpai.db";
        //"C:\Users\muril\source\repos\biblioteca 2024\dbpai.db";
        private static SQLiteConnection DbConnection() { 
        sQLiteConnection = new SQLiteConnection("DataSource="+path);
            sQLiteConnection.Open();
            return sQLiteConnection;
        }
           
    
    }
}
