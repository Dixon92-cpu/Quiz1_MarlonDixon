// Declaración de variables
float num1, num2, num3, num4;

// Solicitar los números
 Console.Write("Ingrese el primer número: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
num2 = float.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer número: ");
num3 = float.Parse(Console.ReadLine());

Console.Write("Ingrese el cuarto número: ");
num4 = float.Parse(Console.ReadLine());

// Comparar cuál número es mayor
if (num1 > num2 && num1 > num3 && num1 > num4)
{
    Console.WriteLine("El número mayor es: " + num1);
}

if (num2 > num1 && num2 > num3 && num2 > num4)
{
    Console.WriteLine("El número mayor es: " + num2);
}

if (num3 > num1 && num3 > num2 && num3 > num4)
{
    Console.WriteLine("El número mayor es: " + num3);
}

if (num4 > num1 && num4 > num2 && num4 > num3)
{
    Console.WriteLine("El número mayor es: " + num4);
}