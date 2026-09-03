//Declaracion de las variables
float monto, descuento, total;
int tipo;

//pedir que ingrese el monto total del cliente
Console.Write("Cual es el monto total de la compra del cliente?");
monto = float.Parse(Console.ReadLine());

//pedir el tipo de cliente uno o dos
Console.Write("Tipo de cliente 1 o 2 o 3: \n");
tipo = int.Parse(Console.ReadLine());

//Utilizacionn de la sentencias Switch
switch (tipo)
{
    case 1:
        Console.WriteLine("El cliente es de tipo regular. no resibe descuento.");
        Console.WriteLine("Monto a pagar." + monto);
        break;

    case 2:
        switch (monto > 100)
        {
            case true:
                descuento = monto * 0.15f;
                total = monto - descuento;
                Console.WriteLine("tipo de cliente 2 (recibe descuento");
                Console.WriteLine("Monto a pagar." + total);
            break;


            case false:
                Console.WriteLine("el cliente no recibe descuento");
                Console.WriteLine("Monto a pagar" + monto);
            break;
        }
    break;

    case 3:
        switch (monto > 100)
        {
            case true:
                descuento = monto * 0.15f;
                total = monto - descuento;
                Console.WriteLine("Tipo de cliente 3: (VIP)");
                Console.WriteLine("Monto a pagar." + monto);
                break;


            case false:
                Console.WriteLine("el cliente no recibe descuento");
                Console.WriteLine("Monto a pagar" + monto);
                break;
        }
    break;

    default:
        Console.WriteLine("Opcion invalidado");
        break;

}


