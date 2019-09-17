using System.Collections.Generic;
using myshop.Models;

namespace myshop.Services
{
    public interface IProdutoServico
    {
        List<Produto> BuscarTodos();
        List<Produto> BucarPorPesquisa(string pesquisa);
        bool InserirProduto(Produto produto);
        bool AlterarProduto(Produto produto);
        bool ExcluirProduto(Produto produto);
    }
}