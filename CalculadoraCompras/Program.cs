const double porcDescuento = 0.1;

static void LeerDatos(double precio, int cantidad)
{
    Console.WriteLine("Ingrese precio:");
    preciox = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantida:");
    cantidadx = int.Parse(Console.ReadLine());
}

static double CalcularSubtotal(double preciox, int cantidadx)
{
    double sub_total = preciox * cantidadx;
    return sub_total;
}

static double CalcularDescuento(double subtotalx)
{
    return subtotalx * porcDescuento;
}

static double CalcularTotal(double subtotalx, double descuentox)
{
    return subtotalx - descuentox;
}

Console.WriteLine("Bienvenido a la Calculadora de Compra");
double precio =0;
int cantidad =0;
LeerDatos(ref precio,ref cantidad);

//Comprobando
double sub_total = CalcularSubtotal(precio, cantidad);
System.Console.WriteLine($"Subtotal: {subtotal}");

double descuento = CalcularDescuento(subtotal);
System.Console.WriteLine($"Descuneto: {descuento}");

double total = CalcularTotal(subtotal,descuento);
System.Console.WriteLine($"Descuneto: {total}");