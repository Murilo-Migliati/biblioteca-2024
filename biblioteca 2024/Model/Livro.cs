using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_2024.Model
{
    public class Livro
    {
        public Livro(string titulo, string autor, string editora, int anopub)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            anoPublicacao = anopub;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int anoPublicacao { get; set; }
    }
}
