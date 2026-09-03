using System;

class Program
{
    static void Main(string[] args)
    {
        int edad, boletos, tipo;

        // Pedir la edad
        Console.Write("Ingrese la edad: ");
        edad = int.Parse(Console.ReadLine());

        // Pedir cantidad de boletos
        Console.Write("Ingrese la cantidad de boletos disponibles: ");
        boletos = int.Parse(Console.ReadLine());

        // Pedir tipo de entrada
        Console.Write("Tipo de entrada (1 = General, 2 = VIP, 3 = Invitado): ");
        tipo = int.Parse(Console.ReadLine());

        // Verificar el tipo de entrada
        switch (tipo)
        {
            case 1:
                switch (edad >= 18 && boletos >= 1)
                {
                    case true:
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada: General");
                        break;

                    case false:
                        Console.WriteLine("Entrada rechazada");
                        Console.WriteLine("No cumple con las condiciones establecidas.");
                        break;
                }
                break;

            case 2:
                switch (edad >= 18 && boletos >= 1)
                {
                    case true:
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada: VIP");
                        break;

                    case false:
                        Console.WriteLine("Entrada rechazada");
                        Console.WriteLine("No cumple con las condiciones establecidas.");
                        break;
                }
                break;

            case 3:
                switch (edad >= 18 && boletos >= 1)
                {
                    case true:
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada: Invitado");
                        break;

                    case false:
                        Console.WriteLine("Entrada rechazada");
                        Console.WriteLine("No cumple con las condiciones establecidas.");
                        break;
                }
                break;

            default:
                Console.WriteLine("Entrada rechazada");
                Console.WriteLine("Tipo de entrada inválido.");
                break;
        }
    }
}
