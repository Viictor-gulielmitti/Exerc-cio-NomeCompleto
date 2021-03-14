using System;

namespace Nome_Sobrenome
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome;
            string segundoNome;

            Console.WriteLine("Digite seu primeiro nome:");
            primeiroNome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            segundoNome = Console.ReadLine();
            Console.WriteLine($"Nome completo: {primeiroNome} {segundoNome}");
            Console.Write($"Nome de catalogo:{segundoNome}".ToUpper());
            Console.Write($", {primeiroNome}");

        }
    }
}