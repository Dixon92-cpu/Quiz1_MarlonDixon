using System;

class Program
{
    static void Main(string[] args)
    {
        float num1, num2, num3, num4;

        // Pedir los cuatro números
        Console.Write("Ingrese el primer número: ");
        num1 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        num3 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        num4 = float.Parse(Console.ReadLine());

        // Comparar el primer número
        switch (num1 > num2 && num1 > num3 && num1 > num4)
        {
            case true:
                Console.WriteLine("El número mayor es: " + num1);
                break;

            case false:

                // Comparar el segundo número
                switch (num2 > num1 && num2 > num3 && num2 > num4)
                {
                    case true:
                        Console.WriteLine("El número mayor es: " + num2);
                        break;

                    case false:

                        // Comparar el tercer número
                        switch (num3 > num1 && num3 > num2 && num3 > num4)
                        {
                            case true:
                                Console.WriteLine("El número mayor es: " + num3);
                                break;

                            case false:

                                // Si no fue ninguno de los anteriores,
                                // el mayor es el cuarto número
                                Console.WriteLine("El número mayor es: " + num4);
                                break;
                        }
                        break;
                }
                break;
        }
    }
}