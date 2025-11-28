namespace SistemaDeChamados.Domain;

public class Operador
{
    public int OperadorId { get; private set; }
    public string Nome { get; private set; }

    public Operador(string name)
    {
        Validar(name);
        Nome = name;
    }

    public static Operador CriarOperador(string name)
    {
        Validar(name);
        return new Operador(name);
    }


    public void Update(string name)
    {
        Validar(name);
        Nome = name;
    }

    private static void Validar(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("O nome do operador é obrigatório.");

        if (name.Length < 2)
            throw new ArgumentException("O nome do operador deve ter pelo menos 2 caracteres.");
    }
}
