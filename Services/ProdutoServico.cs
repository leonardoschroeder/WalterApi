using System.Collections.Generic;
using myshop.Models;
using MongoDB.Driver;
using System.Linq;

namespace myshop.Services
{
    public class ProdutoServico : IProdutoServico
    {
        MongoClient conexao;
        IMongoDatabase db;
        public ProdutoServico()
        {
            conexao = new MongoClient("mongodb://172.18.0.35:27017");
            db = conexao.GetDatabase("dbleo");
            if(db.GetCollection<Produto>("Produtos") == null)
                db.CreateCollection("Produtos");
        }

        public List<Produto> BuscarTodos()
        {
            //var produtos = new List<Produto>();
            //var produto = new Produto();
            var tabelaProdutos = db.GetCollection<Produto>("Produtos");

            return tabelaProdutos.Find<Produto>(p => true).ToList();
        }

        public List<Produto> BucarPorPesquisa(string pesquisa)
        {
            //var produtos = new List<Produto>();
            //var produto = new Produto();
            var tabelaProdutos = db.GetCollection<Produto>("Produtos");

            return tabelaProdutos.Find<Produto>(p => p.Nome == pesquisa || p.Descricao == pesquisa).ToList();
        }

        public bool InserirProduto(Produto produto)
        {
            var tabelaProdutos = db.GetCollection<Produto>("Produtos");
            tabelaProdutos.InsertOne(produto);
            return true;
        }

        public bool AlterarProduto(Produto produto)
        {
            var tabelaProdutos = db.GetCollection<Produto>("Produtos");
            //tabelaProdutos.DeleteOne(produto);
            return true;
        }

        public bool ExcluirProduto(Produto produto)
        {
            var tabelaProdutos = db.GetCollection<Produto>("Produtos");
            tabelaProdutos.InsertOne(produto);
            return true;
        }


    }
}