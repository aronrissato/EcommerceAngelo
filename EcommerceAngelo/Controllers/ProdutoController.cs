using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceAngelo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAngelo.Controllers
{
    public class ProdutoController : Controller
    {
        //Métodos dentro de um controller são chamados de actions
        private readonly ProdutoDAO _produtoDAO;

        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string txtNome, string txtDescricao, string txtPreco, string txtQuantidade)
        {
            //Produto produto = new Produto();
            //produto.Nome = txtNome...;

            Produto produto = new Produto
            {
                Nome = txtNome,
                Descricao = txtDescricao,
                Preco = Convert.ToInt32(txtPreco),
                Quantidade = Convert.ToInt32(txtQuantidade)
            };

            _produtoDAO.CadastrarProduto(produto);


            return View();
            //return RedirectToAction("Index");
        }

    }
}