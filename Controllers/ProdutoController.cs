using CSharpProjeto.DTOs;
using Microsoft.AspNetCore.Mvc;
using CSharpProjeto.Models;
using CSharpProjeto.Repositories;

namespace CSharpProjeto.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly ProdutoRepo _produtoRepo;

    public ProdutoController(ProdutoRepo produtoRepo)
    {
        _produtoRepo = produtoRepo;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_produtoRepo.GetAll());
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateProdutoDto dto)
    {
        var produto = new Produto { Nome = dto.Nome, Preco = dto.Preco };
        _produtoRepo.Add(produto);
        return Created("", produto);
    }

    [HttpDelete]
    public IActionResult Delete([FromBody] int id)
    {
        if (id <= 0) return BadRequest();
        
        _produtoRepo.Remove(id);
        return Ok();
    }
}
