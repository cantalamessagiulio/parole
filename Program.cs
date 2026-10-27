
using System;
class Program
{

    static void Main()
    {
        string frase;
        Console.WriteLine("Inserisci una frase");
        frase= Console.ReadLine();
       string[] parole=frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Numero di parole: " + parole.Length);
    }
}