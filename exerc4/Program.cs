class Program
{
        static void Main()
    {

        Boolean menu = true;

        while (menu == true)
        {


            Console.WriteLine("[1] Celsius para Fahrenreit");
            Console.WriteLine("[2] Fahrenreit para Celsius");
            Console.WriteLine("[3] Sair \n ");
            Console.WriteLine("Digite a opção desejada: ");
            int opcao = int.Parse( Console.ReadLine() ?? "0");


            switch (opcao)
            {
                case 1:

                    {
                        Console.WriteLine("Digite a temperatura em celsius: ");
                        float celsius = float.Parse(Console.ReadLine() ?? "0");
                        float fahrenheit = (celsius * 1.8f) + 32;
                        Console.WriteLine("A temperatura em Fahrenheit é " + fahrenheit + "\n");
                        break;
                    }

                case 2:

                    {
                        Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                        float fahrenheit = float.Parse(Console.ReadLine() ?? "0");
                        float celsius = (fahrenheit - 32) / 1.8f;
                        Console.WriteLine("A temperatura em Celsius é " + celsius + "\n");
                        break;
                    }

                case 3:
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. \n");
                    break;
            }

        }


    }

}