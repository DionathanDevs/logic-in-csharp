using System;
using System.Globalization;

class Program {
    static void Main() {
        Console.WriteLine("Digite a sua altura (ex: 1,74 ou 1.74): ");
        string alturaInput = Console.ReadLine() ?? "0";
        alturaInput = alturaInput.Replace(',', '.');
        float altura = float.Parse(alturaInput, CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o seu peso: ");
        string pesoInput = Console.ReadLine() ?? "0";
        pesoInput = pesoInput.Replace(',', '.');
        float peso = float.Parse(pesoInput, CultureInfo.InvariantCulture);

        float imc = peso / (altura * altura);

        Console.WriteLine($"Seu IMC é: {imc:F2}");

        if(imc < 18.5){
            Console.WriteLine("Abaixo do peso.");
        } else if(imc >= 18.5 && imc <= 24.9){
            Console.WriteLine("Peso normal.");
        } else if(imc >= 25 && imc <= 29.9){
            Console.WriteLine("Sobrepeso.");
        } else {
            Console.WriteLine("Obesidade.");
        }
    }
}
