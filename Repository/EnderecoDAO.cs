using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EnderecoDAO : IRepository<Endereco>
    {
        private readonly Context _context;

        public EnderecoDAO(Context context)
        {
            _context = context;
        }

        public Endereco BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Cadastrar(Endereco objeto)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
