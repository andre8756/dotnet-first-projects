public class Veiculo
{
    private string _marca { get; set; }
    private int _ano { get; set; }

    public Veiculo(string marca, int ano)
    {
        if (string.IsNullOrWhiteSpace(marca))
        {
            throw new ArgumentException("A marca não pode estar vazia");
        }

        if (ano <= 0)
        {
            throw new ArgumentException("O ano precisa ser maior que zero");
        }

        _marca = marca;
        _ano = ano;
    }

    public virtual void Ligar()
    {
        Console.WriteLine("Veículo ligado!");
    }

    public virtual void Detalhes()
    {
        Console.WriteLine("Marca: " + _marca);
        Console.WriteLine("Ano: " + _ano);
    }
}