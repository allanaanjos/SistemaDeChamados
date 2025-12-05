namespace SistemaDeChamados.Application;

public class AtualizarTicketRequest : RemoverTicketRequest
{
    public string? Solicitante { get; set; }
    public string? Assunto { get; set; }

    public int? CategoriaId { get; set; }

    public int? OperadorId { get; set; }
}