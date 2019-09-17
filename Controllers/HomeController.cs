using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.Services;

namespace myshop.Controllers
{
    public class HomeController : Controller
    {

        private IProdutoServico produtoServico;

        public HomeController(IProdutoServico _produtoServico)
        {
            produtoServico = _produtoServico;
        }

        public IActionResult Index(String pesquisa)
        {
            Console.WriteLine("@@@@@@@@@ index search" + pesquisa);
            var listaProduto = new List<Produto>();
            if(String.IsNullOrEmpty(pesquisa))
                listaProduto = produtoServico.BuscarTodos();
            else
                listaProduto = produtoServico.BucarPorPesquisa(pesquisa);
            return View(listaProduto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
