using System.ComponentModel.DataAnnotations;

namespace CSharpProjeto.DTOs;

public class CreateProdutoDto
{
    [Required] 
    [StringLength(20)] 
    public string Nome { get; set; } = string.Empty;
    
    [Required]
    [Range(10, 100)]
    public int Preco { get; set; }
}