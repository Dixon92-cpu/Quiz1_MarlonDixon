using System;

class Program
{
    static void Main(string[] args)
    {
        float notaFinal, porcentaje;
        int tipo;

        // Pedir la nota final
        Console.Write("Ingrese la nota final del estudiante: ");
        notaFinal = float.Parse(Console.ReadLine());

        // Pedir el porcentaje de asistencia
        Console.Write("Ingrese el porcentaje de asistencia: ");
        porcentaje = float.Parse(Console.ReadLine());

        // Pedir el tipo de estudiante
        Console.Write("Tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio): ");
        tipo = int.Parse(Console.ReadLine());

        // Verificar el tipo de estudiante
        switch (tipo)
        {
            case 1:
                switch (notaFinal >= 71 && porcentaje >= 80)
                {
                    case true:
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                        break;

                    case false:
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                        break;
                }
                break;

            case 2:
                switch (notaFinal >= 71 && porcentaje >= 80)
                {
                    case true:
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                        break;

                    case false:
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                        break;
                }
                break;

            case 3:
                switch (notaFinal >= 71 && porcentaje >= 80)
                {
                    case true:
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                        break;

                    case false:
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                        break;
                }
                break;

            default:
                Console.WriteLine("Tipo de estudiante inválido.");
                break;
        }
    }
}
