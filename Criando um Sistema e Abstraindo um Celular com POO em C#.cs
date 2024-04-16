using System;

// Classe abstrata Celular
abstract class Celular
{
    public abstract void Ligar();
    public abstract void Desligar();
    public abstract void EnviarMensagem(string mensagem);
    public abstract void FazerChamada(string numero);
}

// Classe concreta SamsungGalaxy
class SamsungGalaxy : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("Samsung Galaxy: Ligando...");
    }

    public override void Desligar()
    {
        Console.WriteLine("Samsung Galaxy: Desligando...");
    }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Samsung Galaxy: Enviando mensagem '{mensagem}'");
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Samsung Galaxy: Chamando o número {numero}");
    }
}

// Classe concreta IPhone
class IPhone : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("IPhone: Ligando...");
    }

    public override void Desligar()
    {
        Console.WriteLine("IPhone: Desligando...");
    }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"IPhone: Enviando mensagem '{mensagem}'");
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"IPhone: Chamando o número {numero}");
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        Celular celular1 = new SamsungGalaxy();
        Celular celular2 = new IPhone();

        celular1.Ligar();
        celular1.EnviarMensagem("Olá, t
