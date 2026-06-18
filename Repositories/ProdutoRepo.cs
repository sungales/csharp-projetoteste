using CSharpProjeto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharpProjeto.Repositories;

public class ProdutoRepo
{
    private readonly List<Produto> _produtos = [];
    private int _novoId = 1;
    
    public void Add(Produto produto)
    {
        produto.Id = _novoId;
        _novoId++;
        _produtos.Add(produto);
    }

    public List<Produto> GetAll()
    {
        return _produtos;
    }

    public bool Remove(int id)
    {
        var produto = _produtos.FirstOrDefault(p => p.Id == id);
        if (produto is null)
            return false;

        _produtos.Remove(produto);
        return true;
    }
}
