using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- - - - - Digite uma frase abaixo - - - - -");
        Console.Write("Frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine("Resultados:");
        Console.WriteLine("Frase: " + frase);
        Console.ReadLine();
    }
}