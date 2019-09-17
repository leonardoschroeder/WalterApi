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
    public class ProdutoController : Controller
    {
        private IProdutoServico produtoServico;

        public ProdutoController(IProdutoServico _produtoServico)
        {
            produtoServico = _produtoServico;
        }

        public IActionResult Index()
        {
            /* var listaProduto = new List<Produto>();
            listaProduto = produtoServico.BuscarTodos();
            return View(listaProduto);*/
            Console.WriteLine("testando o codigo01");
            return View();
        }
        [HttpPost]
        public IActionResult Index(Produto produto){
            Console.WriteLine("Nome");
            Console.WriteLine(produto.Nome);
            Console.WriteLine("Preco");
            Console.WriteLine(produto.Preco);
            Console.WriteLine("Preco Promocional");
            Console.WriteLine(produto.PrecoPromocional);
            Console.WriteLine("Descrição");
            Console.WriteLine(produto.Descricao);

            return View();
        }

        [HttpGet]
        public IActionResult Form(){
            return View();
        }

        [HttpPost]
        public IActionResult Form(Produto produto){
            Console.WriteLine("Nome");
            Console.WriteLine(produto.Nome);
            Console.WriteLine("Preco");
            Console.WriteLine(produto.Preco);
            Console.WriteLine("Preco Promocional");
            Console.WriteLine(produto.PrecoPromocional);
            Console.WriteLine("Descrição");
            Console.WriteLine(produto.Descricao);
            produtoServico.InserirProduto(produto);
            return View();
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