using System.ComponentModel.DataAnnotations;

namespace SistemaDeChamados.Application;

public class ObterTicketPorSolicitanteRequest
{
    [Required(ErrorMessage = "Solicitante é Obrigatório.")]
    [MinLength(3, ErrorMessage = "Solicitante deve conter pelo menos 3 caracteres.")]
    public string Solicitante { get; set; } = string.Empty;
}