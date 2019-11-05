using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
    }
}