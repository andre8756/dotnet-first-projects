
try
{
    Carro car1 = new Carro("marca", "modelo", 1956);
    Carro car2 = new Carro("marca", "modelo", 1956);
}
catch (Exception ex)
{
    Console.WriteLine("Não foi possível cadastrar o veículo: " + ex.Message);
}

int[] numeros = new int[5];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
numeros[3] = 4;
numeros[4] = 5;

foreach(int numero in numeros)
{
    Console.WriteLine(numero);
}

