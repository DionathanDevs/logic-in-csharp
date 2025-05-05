using System;
using System.Globalization;
class Program
{
    static void Main()
    {

        Console.WriteLine("Digite a sua altura: ");
        float altura = float.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o seu peso: ");
        float peso = float.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

        float imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso.");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Peso normal.");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Sobrepeso.");
        }
        else
        { 
            Console.WriteLine("Obesidade.");
        }

    }
}
