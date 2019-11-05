using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class UsuarioDAO : IRepository<Usuario>
    {
        private readonly Context _context;

        public UsuarioDAO(Context context)
        {
            _context = context;
        }

        public bool Cadastrar(Usuario usuario)
        {
            if (BuscarPorEmail(usuario) == null)
            {
                _context.Add(usuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario BuscarPorEmail(Usuario usuario)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email.Equals(usuario.Email));
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public List<Usuario> ListarTodos()
        {
            return _context.Usuarios.ToList();
        }
    }
}
