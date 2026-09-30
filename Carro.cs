public class Carro
{
    public string Modelo;
    public string Marca;
    public int Ano;

    public Carro(string modelo, string marca, int ano)
    {
        if (string.IsNullOrWhiteSpace(modelo))
        {
            throw new ArgumentException("O modelo não pode estar vazio!");
        }

        if (string.IsNullOrWhiteSpace(marca)){
            throw new ArgumentException("A marca não pode estar vazia");
        }

        if(ano <= 0)
        {
            throw new ArgumentException("O ano precisa ser maior que zero");
        }

        Modelo = modelo;
        Marca = marca;
        Ano = ano;
    }
}

