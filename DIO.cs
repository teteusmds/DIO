using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a placa do veículo: ");
                    string placa = Console.ReadLine();
                    Console.Write("Digite a marca do veículo: ");
                    string marca = Console.ReadLine();
                    Veiculo veiculo = new Veiculo(placa, marca);
                    estacionamento.AdicionarVeiculo(veiculo);
                    break;
                case 2:
                    Console.Write("Digite a placa do veículo a ser removido: ");
                    string placaRemover = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placaRemover);
                    break;
                case 3:
                    estacionamento.ListarVeiculos();
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}

git 

class Veiculo
{
    public string Placa { get; }
    public string Marca { get; }

    public Veiculo(string placa, string marca)
    {
        Placa = placa;
        Marca = marca;
    }
}

class Estacionamento
{
    private List<Veiculo> veiculos = new List<Veiculo>();

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
        Console.WriteLine("Veículo adicionado com sucesso.");
    }

    public void RemoverVeiculo(string placa)
    {
        Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
        if (veiculo != null)
        {
            veiculos.Remove(veiculo);
            Console.WriteLine("Veículo removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado.");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Lista de veículos:");
        foreach (Veiculo veiculo in veiculos)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Marca: {veiculo.Marca}");
        }
    }
}
