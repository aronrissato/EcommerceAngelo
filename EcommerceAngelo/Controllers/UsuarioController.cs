using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository;

namespace EcommerceAngelo.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly EnderecoDAO _enderecoDAO;

        public UsuarioController(UsuarioDAO usuarioDAO, EnderecoDAO enderecoDAO)
        {
            _usuarioDAO = usuarioDAO;
            _enderecoDAO = enderecoDAO;
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_usuarioDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
            Usuario u = new Usuario();
            if (TempData["Usuario"] != null)
            {
                string resultado = TempData["Usuario"].ToString();
                //Newtonsoft.Json
                u.Endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                if (_usuarioDAO.Cadastrar(u))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse email já está sendo utilizado!");
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult BuscarCep(Usuario u)
        {
            string url = $"https://viacep.com.br/ws/{u.Endereco.Cep}/json/";
            WebClient client = new WebClient();
            TempData["Usuario"] = client.DownloadString(url);
            return RedirectToAction(nameof(Cadastrar));
        }
    }
}