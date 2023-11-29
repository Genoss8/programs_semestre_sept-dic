int menu;
Console.WriteLine("El menu contiene \n 1-pizza y un resfresco \n 2-pizza y boneless\n 3-pizza, ensalada y refresco");
menu= int.Parse(Console.ReadLine());
switch (menu)
{
    case 1:
        Console.WriteLine("se le entregara un combo de pizza y un refresco");
        Console.WriteLine("su precio total es: $120");
        break;
    case 2:
        Console.WriteLine("se le entregara un combo de pizza y boneless");
        Console.WriteLine("su precio total es: $170");
        break;
    case 3:
        Console.WriteLine("se le entregara un combo de pizza,ensalada y refresco");
        Console.WriteLine("su precio total es: $200");
        break;
    default :
        Console.WriteLine("se le entregara una pizza sencilla");
        Console.WriteLine("su precio total es: $100");
        break;
}