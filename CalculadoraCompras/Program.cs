using System.Numerics;

const double porcDescuento = 0.1;

static void LeerDatos(ref double precio, ref int cantidad)
{
    Console.WriteLine("Ingrese precio:");
    precio = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese cantidad:");
    cantidad = int.Parse(Console.ReadLine()!);
}

static double CalcularSubtotal(double preciox, int cantidadx)
{
    double sub_total = preciox * cantidadx;
    return sub_total;
}

static double CalcularDescuento(double subtotalx, double porcentaje)
{
    return subtotalx * porcentaje;
}

static double CalcularTotal(double subtotalx, double descuentox)
{
    return subtotalx - descuentox;
}

Console.WriteLine("Bienvenido a la Calculadora de Compra");
double precio = 0;
int cantidad = 0;

LeerDatos(ref precio, ref cantidad);

// Comprobando
double subtotal = CalcularSubtotal(precio, cantidad);
Console.WriteLine($"Subtotal: {subtotal}");

double descuento = CalcularDescuento(subtotal, porcDescuento);
Console.WriteLine($"Descuento: {descuento}");

double total = CalcularTotal(subtotal, descuento);
Console.WriteLine($"Total: {total}");