namespace SistemaDeChamados.Domain;

public class Categoria
{
    public int CategoriaId { get; private set; }
    public string Nome { get; private set; }

    public Categoria(string nome)
    {
        ValidarNome(nome);
        Nome = nome;
    }

    public void AtualizarNome(string nome)
    {
        ValidarNome(nome);
        Nome = nome;
    }


    private void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da categoria é obrigatório.", nameof(nome));
    }
}
