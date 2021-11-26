using System;

class Aula08
{
    static void Main()
    {
        Console.WriteLine("Escreva seu nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("seu nome é:\n{0,10}",nome);
        Console.WriteLine("escreva sua idade:");
        var idade = Console.ReadLine();
        Console.WriteLine("Sua idade é:{0,4}",int.Parse(idade));     
    }
    
}