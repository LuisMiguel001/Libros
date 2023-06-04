using Libros.DAL;
using Libros.Models;

namespace Libros.BLL
{
    public class LibrosBLL
    {
        private readonly Context _context;

        public LibrosBLL(Context context)
        {
            _context = context;
        }

        public bool Existe(int libroId)
        {
            return _context.Libro.Any(s => s.LibrosId == libroId); 
        }

        public bool Insertar(Libro libro)
        {
            _context.Libro.Add(libro);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }
    }
}
