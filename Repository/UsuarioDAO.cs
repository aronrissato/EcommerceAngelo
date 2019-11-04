using Domain;
using System;
using System.Collections.Generic;
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

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Cadastrar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
