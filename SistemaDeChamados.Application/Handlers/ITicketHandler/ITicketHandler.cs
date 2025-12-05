using SistemaDeChamados.Domain;

namespace SistemaDeChamados.Application;


public interface ITicketHandler
{
    Task<List<Ticket>> TicketsAsync(ObterTodosOsTicketsRequest rerquest);
    Task<Ticket> ObterTicketPorIdAsync(ObterTcketPorIdRequest request);
    Task CriarTicketAsync(CriarTicketRequest request);
    Task UpdateTicketAsync(AtualizarTicketRequest request);
    Task RemoverTicketAsync(RemoverTicketRequest request);
    Task<Ticket> ObterTicketPorAsync(ObterTicketPorSolicitanteRequest request);
}