string nombre;
int edad;
Console.WriteLine("escriba su nombre");
nombre=(Console.ReadLine());
Console.WriteLine("indique su edad");
edad=int.Parse(Console.ReadLine());
    if (edad<=18)
{
    Console.WriteLine("puedes votar");
    }
    else
    {
    Console.WriteLine("debes esperar.....hasta luego   "+nombre);
    }
