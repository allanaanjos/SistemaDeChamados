using System.ComponentModel.DataAnnotations;

namespace SistemaDeChamados.Application;

public class RemoverTicketRequest
{
    [Required(ErrorMessage = "Id é Obrigatório.")]
    public int Id { get; set; }
}