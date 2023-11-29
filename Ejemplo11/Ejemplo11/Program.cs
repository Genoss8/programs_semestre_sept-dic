internal class Program
{
    private static void Main(string[] args)
    {
            string garantia = "si";
            double precio;
            double precioTotal;
            string modCell;
            Console.WriteLine("Que modelo de celular se comprara?");
            modCell=(Console.ReadLine());
            Console.WriteLine("El precio del celular es? ");
            precio=double.Parse(Console.ReadLine());
            Console.WriteLine("Desea comprar una garantia extra?,(con un costo del 20% del valor del celular)");
            Console.WriteLine("teclee:1-si el cliente desea la garantia extra.\n teclee 2-si el cliente no desea la garantia extra.");
            garantia=(Console.ReadLine());
            if (garantia == "si")
            {
                precioTotal = precio+(precio *.20);
                Console.WriteLine("El modelo de celular que compro es: " + modCell);
                Console.WriteLine("Su total a pagar es: "+ precioTotal);
            }
            else
            {
                Console.WriteLine("se le agregara un iva del 10% al costo del celular");
                precioTotal=precio+(precio*.10);
                Console.WriteLine("El modelo de celular que compro es: " + modCell);
                Console.WriteLine("El precio del celular con el iva del 10% es:"+precioTotal);

            }
    }
}