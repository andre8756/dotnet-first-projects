public class Carro : Veiculo
{
    private string _modelo {get; set;}

    public Carro(string modelo, string marca, int ano) : base(marca, ano)
    {
        if (string.IsNullOrWhiteSpace(modelo)) 
        {
            throw new ArgumentException("O modelo não pode estar vazio!");
        }

    }

    public override void Ligar()
    {
        Console.WriteLine("Partida Carro");
    }
}

