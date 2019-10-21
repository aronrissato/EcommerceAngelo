using EcommerceAngelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAngelo.Controllers
{
    public class ProdutoDAO
    {
        private readonly Context _context;

        public ProdutoDAO(Context context)
        {
            _context = context;
        }
        
        public void CadastrarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }


    }
}
