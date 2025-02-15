using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        double division = (double)numero1 / numero2;

        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("La resta es: " + resta);
        Console.WriteLine("La multiplicación ess: " + multiplicacion);
        Console.WriteLine("La división es: " + division);
    }
}
