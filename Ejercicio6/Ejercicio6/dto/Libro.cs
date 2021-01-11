using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Libro
    {
        int isbn, numPaginas;
        string titulo, autor;

        public Libro(int isbn, int numPaginas, string titulo, string autor)
        {
            this.isbn = isbn;
            this.numPaginas = numPaginas;
            this.titulo = titulo;
            this.autor = autor;
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }

       
        public override string ToString()
        {
            return String.Format("El libro {0}, con ISBN {1}, creado por el autor {2} tiene {3} paginas", titulo,isbn,Autor,numPaginas);
        }
    }
}

