using System.ComponentModel.DataAnnotations;

namespace SistemaDeChamados.Domain;

public class CriarTicketRequest
{
    [Required(ErrorMessage = "O Nome é Obrigatório.")]
    [MinLength(3, ErrorMessage = "O Nome deve conter no minimo 3 caracteres.")]
    public string Solicitante { get; set; } = string.Empty;

    [Required(ErrorMessage = "O Assunto é Obrigatório.")]
    [MinLength(5, ErrorMessage = "O Assunto deve conter no minimo 5 caractere.")]
    public string Assunto { get; set; } = string.Empty;

    [Required(ErrorMessage = "CategoriaId é obrigatório.")]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "OperadorId é obrigatório.")]
    public int OperadorId { get; set; }
}