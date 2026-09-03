// Declaración de variables
float notaFinal, porcentajeAsistencia;
int tipo;

// Solicitar la nota final
Console.Write("Ingrese la nota final del estudiante: ");
notaFinal = float.Parse(Console.ReadLine());

// Solicitar el porcentaje de asistencia
Console.Write("Ingrese el porcentaje de asistencia: ");
porcentajeAsistencia = float.Parse(Console.ReadLine());

// Solicitar el tipo de estudiante
Console.Write("Ingrese el tipo de estudiante (1=Regular, 2=Becado, 3=Intercambio): ");
tipo = int.Parse(Console.ReadLine());

// Verificar si cumple con todas las condiciones
if ((tipo == 1 || tipo == 2 || tipo == 3) &&
notaFinal >= 71 &&
porcentajeAsistencia >= 80)
{
    Console.WriteLine("Aprobado");
    Console.WriteLine("Nota obtenida: " + notaFinal);
}
else if (tipo == 1 || tipo == 2 || tipo == 3)
{
    Console.WriteLine("No aprobado");
    Console.WriteLine("Nota final: " + notaFinal);
}
else
{
    Console.WriteLine("Tipo de estudiante inválido");
}
