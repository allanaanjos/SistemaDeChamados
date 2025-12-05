using SistemaDeChamados.Application;
using SistemaDeChamados.Domain;

namespace SistemaDeChamados.Infra;

public class TicketHandler : ITicketHandler
{
    public Task CriarTicketAsync(CriarTicketRequest request)
    {
        
    }

    public Task<Ticket> ObterTicketPorAsync(ObterTicketPorSolicitanteRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> ObterTicketPorIdAsync(ObterTcketPorIdRequest request)
    {
        throw new NotImplementedException();
    }

    public Task RemoverTicketAsync(RemoverTicketRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<List<Ticket>> TicketsAsync(ObterTodosOsTicketsRequest rerquest)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTicketAsync(AtualizarTicketRequest request)
    {
        throw new NotImplementedException();
    }
}