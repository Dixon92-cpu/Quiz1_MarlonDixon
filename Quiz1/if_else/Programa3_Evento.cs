// Declaración de variables
int edad, boletos, tipo;

// Solicitar la edad
Console.Write("Ingrese la edad de la persona: ");
edad = int.Parse(Console.ReadLine());

// Solicitar la cantidad de boletos
Console.Write("Ingrese la cantidad de boletos disponibles: ");
boletos = int.Parse(Console.ReadLine());

// Solicitar el tipo de entrada
Console.Write("Ingrese el tipo de entrada (1=General, 2=VIP, 3=Invitado): ");
tipo = int.Parse(Console.ReadLine());

// Verificar si cumple todas las condiciones
if ((tipo == 1 || tipo == 2 || tipo == 3) &&
edad >= 18 &&
boletos >= 1)
{
    Console.WriteLine("Entrada autorizada.");

    if (tipo == 1)
    {
        Console.WriteLine("Tipo de entrada: General");
    }
    else if (tipo == 2)
    {
        Console.WriteLine("Tipo de entrada: VIP");
    }
    else
    {
        Console.WriteLine("Tipo de entrada: Invitado");
    }
}
else
{
    Console.WriteLine("Entrada rechazada.");
    Console.WriteLine("No cumple con las condiciones establecidas.");
}