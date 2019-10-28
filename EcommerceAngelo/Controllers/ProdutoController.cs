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
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarProdutos());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto p)
        {
            _produtoDAO.CadastrarProduto(p);
            return RedirectToAction("Index");
        }

        public IActionResult RemoverProduto(int id)
        {

            _produtoDAO.RemoverProduto(id);
            return RedirectToAction("Index");
        }

        public IActionResult EditarProduto(int id)
        {
            return View(_produtoDAO.BuscarProdutoPorId(id));

        }

        [HttpPost]
        public IActionResult EditarProduto(Produto p)
        {
            _produtoDAO.EditarProduto(p);
            return RedirectToAction("Index");
        }
    }
}