using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ProdutoDAO : IRepository<Produto>
    {
        private readonly Context _context;

        public ProdutoDAO(Context context)
        {
            _context = context;
        }

        public bool Cadastrar(Produto produto)
        {
            if (BuscarProdutoPorNome(produto) == null)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Produto BuscarProdutoPorNome(Produto produto)
        {
            return _context.Produtos.FirstOrDefault(x => x.Nome.Equals(produto.Nome));
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }

        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void RemoverProduto(int id)
        {
            _context.Produtos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public void EditarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }
}
