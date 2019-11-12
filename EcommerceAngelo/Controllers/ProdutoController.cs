using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace EcommerceAngelo.Controllers
{
    public class ProdutoController : Controller
    {
        //Métodos dentro de um controller são chamados de actions
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly IHostingEnvironment _hosting;

        public ProdutoController(ProdutoDAO produtoDAO, CategoriaDAO categoriaDAO, IHostingEnvironment hosting)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarTodos());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto p, int drpCategorias, IFormFile fupImagem)
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");

            if (ModelState.IsValid)
            {
                //Cadastrar a imagem
                if (fupImagem != null)
                {//pasta: ecommerceimagens

                    string arquivo = Guid.NewGuid().ToString() + Path.GetExtension(fupImagem.FileName);
                    string caminho = Path.Combine(_hosting.WebRootPath, "ecommerceimagens", arquivo);

                    fupImagem.CopyTo(new FileStream(caminho, FileMode.Create));

                    p.Imagem = arquivo;

                }
                else
                {
                    p.Imagem = "semimagem.png";
                }

                p.Categoria = _categoriaDAO.BuscarPorId(drpCategorias);
                if (_produtoDAO.Cadastrar(p))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse produto já existe!");
            }
            return View(p);
        }

        public IActionResult RemoverProduto(int id)
        {
            _produtoDAO.RemoverProduto(id);
            return RedirectToAction("Index");
        }

        public IActionResult EditarProduto(int id)
        {
            return View(_produtoDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult EditarProduto(Produto p)
        {
            _produtoDAO.EditarProduto(p);
            return RedirectToAction("Index");
        }
    }
}