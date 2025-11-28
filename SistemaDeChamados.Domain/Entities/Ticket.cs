namespace SistemaDeChamados.Domain;

public class Ticket
{
    public int TicketId { get; private set; }
    public string Solicitante { get; private set; }
    public string Assunto { get; private set; }
    public Categoria Categoria { get; private set; }
    public Operador Operador { get; private set; }
    public DateTime Criado { get; private set; }


    public Ticket(
        string solicitante,
        string assunto,
        Categoria categoria,
        Operador operador
    )
    {
        Validar(solicitante, assunto, categoria, operador);

        Solicitante = solicitante;
        Assunto = assunto;
        Categoria = categoria;
        Operador = operador;
        Criado = DateTime.Now;
    }

    public static Ticket Create(
        string solicitante,
        string assunto,
        Categoria categoria,
        Operador operador
    )
    {
        return new Ticket(solicitante, assunto, categoria, operador);
    }

    public void Update(
        string? solicitante = null,
        string? assunto = null,
        Categoria? categoria = null,
        Operador? operador = null
    )
    {
        // Se não enviaram nada para atualizar → não faz nada
        if (solicitante == null &&
            assunto == null &&
            categoria == null &&
            operador == null)
            return;

        // Coleta os valores atuais caso algum não tenha sido enviado
        var novoSolicitante = solicitante ?? Solicitante;
        var novoAssunto = assunto ?? Assunto;
        var novaCategoria = categoria ?? Categoria;
        var novoOperador = operador ?? Operador;

        // Valida tudo junto
        Validar(novoSolicitante, novoAssunto, novaCategoria, novoOperador);

        // Aqui já está validado:
        Solicitante = novoSolicitante;
        Assunto = novoAssunto;
        Categoria = novaCategoria;
        Operador = novoOperador;
    }

    
    private static void Validar(
        string solicitante,
        string assunto,
        Categoria categoria,
        Operador operador
    )
    {
        if (string.IsNullOrWhiteSpace(solicitante))
            throw new ArgumentException("Solicitante é obrigatório.");

        if (solicitante.Length < 3)
            throw new ArgumentException("O nome do solicitante deve conter pelo menos 3 caracteres.");

        if (string.IsNullOrWhiteSpace(assunto))
            throw new ArgumentException("Assunto é obrigatório.");

        if (assunto.Length < 5)
            throw new ArgumentException("O assunto deve conter pelo menos 5 caracteres.");

        if (categoria == null)
            throw new ArgumentException("Categoria é obrigatória.");

        if (operador == null)
            throw new ArgumentException("Operador é obrigatório.");
    }
}
