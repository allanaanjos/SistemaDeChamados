namespace SistemaDeChamados.Domain;

public interface IRepository<T> where T : class
{
    Task<T?> ObterPorIdAsync(int id);
    Task<IEnumerable<T>> ObterTodosAsync();
    Task AdicionarAsync(T entidade);
    Task AtualizarAsync(T entidade);
    Task RemoverAsync(T entidade);
}

public interface ICategoriaRepository : IRepository<Categoria>
{
    Task<Categoria?> ObterCategoriaPeloNomeAsync(string nome);
}

public interface IOperadorRepository : IRepository<Operador>
{
    Task<Operador?> ObterOperadorPeloNomeAsync(string nome);
}

public interface ITicketRepository : IRepository<Ticket>
{
    Task<IEnumerable<Ticket>> ObterTicketsPorSolicitanteAsync(string solicitante);
}
