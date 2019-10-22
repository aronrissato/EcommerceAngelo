﻿using EcommerceAngelo.Models;
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

        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void RemoverProduto(int id)
        {
            _context.Produtos.Remove(BuscarProdutoPorId(id));
            _context.SaveChanges();
        }

        public void EditarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }
}
