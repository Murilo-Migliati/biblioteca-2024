using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_2024;

namespace biblioteca_2024.Model
{
    public class Livro
    {
        public Livro(string titulo, string autor, int anopub)
        {
            Titulo = titulo;
            Autor = autor;
            anoPublicacao = anopub;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int anoPublicacao { get; set; }
    }
}
