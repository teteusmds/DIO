using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Suite
{
    public int Numero { get; set; }
    public decimal ValorDiaria { get; set; }
    public int Capacidade { get; set; }
}

class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suite Suite { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }

    public int QuantidadeDias => (int)(DataSaida - DataEntrada).TotalDays;

    public decimal ValorTotal
    {
        get
        {
            decimal valorTotal = Suite.ValorDiaria * QuantidadeDias;
            if (QuantidadeDias > 10)
            {
                valorTotal *= 0.9m; // Aplica desconto de 10% para reservas com mais de 10 dias
            }
            return valorTotal;
        }
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso
        Pessoa pessoa = new Pessoa { Nome = "Fulano", Idade = 30 };
        Suite suite = new Suite { Numero = 1, ValorDiaria = 100, Capacidade = 2 };
        Reserva reserva = new Reserva
        {
            Hospede = pessoa,
            Suite = suite,
            DataEntrada = new DateTime(2024, 4, 1),
            DataSaida = new DateTime(2024, 4, 10)
        };

        Console.WriteLine($"Reserva para {reserva.Hospede.Nome}");
        Console.WriteLine($"Valor total da reserva: R${reserva.ValorTotal:F2}");
    }
}
