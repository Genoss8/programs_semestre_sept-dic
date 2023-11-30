decimal precioProd;
string producto;
int cant;
decimal importP;
decimal cambio;

Console.WriteLine("Ingrese nombre del producto");
producto=(Console.ReadLine());
Console.WriteLine("Ingrese precio del producto");
precioProd=decimal.Parse(Console.ReadLine());
Console.WriteLine("La cantidad total del producto es?");
cant=int.Parse(Console.ReadLine());
importP= precioProd*cant;
Console.WriteLine("su importe total a pagar es:"+ importP);
