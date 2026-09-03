// Declaración de variables
float monto, descuento, total;
int tipo;

// Solicitar el monto de la compra
Console.Write("Ingrese el monto total de la compra: ");
monto = float.Parse(Console.ReadLine());

// Solicitar el tipo de cliente
Console.Write("Ingrese el tipo de cliente (1=Regular, 2=Frecuente, 3=VIP): ");
tipo = int.Parse(Console.ReadLine());

// Verificar si es cliente frecuente o VIP
// y si la compra supera los $100
if ((tipo == 2 || tipo == 3) && monto > 100)
{
    // Calcular el 15% de descuento
    descuento = monto * 0.15f;

    // Calcular el total a pagar
    total = monto - descuento;

    Console.WriteLine("El cliente recibe un descuento del 15%.");
    Console.WriteLine("Monto final a pagar: $" + total);
}
else if (tipo == 1)
{
    // Cliente regular no recibe descuento
    Console.WriteLine("Cliente Regular.");
    Console.WriteLine("No recibe descuento.");
    Console.WriteLine("Monto a pagar: $" + monto);
}
else if ((tipo == 2 || tipo == 3) && monto <= 100)
{
    // Cliente frecuente o VIP pero no supera $100
    Console.WriteLine("No recibe descuento.");
    Console.WriteLine("Monto a pagar: $" + monto);
}
else
{
    // Tipo de cliente incorrecto
    Console.WriteLine("Tipo de cliente inválido.");
}
