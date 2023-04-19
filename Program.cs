using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Este programa compara dos números y determinará si el segundo número es par o impar.");
        Console.WriteLine("Por favor, ingrese el primer número:");
        var num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor, ingrese el segundo número:");
        var num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("El primer número es mayor que el segundo.");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("El primer número es menor que el segundo.");
        }
        else
        {
            Console.WriteLine("Los dos números son iguales.");
        }

        if (num2 % 2 == 0)
        {
            Console.WriteLine("El segundo número es par.");
        }
        else
        {
            Console.WriteLine("El segundo número es impar.");
        }
    }
}
