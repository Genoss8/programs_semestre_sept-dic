﻿decimal precioProd;
string producto;
int cant;
decimal importP;
decimal cambio;
decimal pago;
Console.WriteLine("Ingrese nombre del producto");
producto=(Console.ReadLine());
Console.WriteLine("Ingrese precio del producto");
precioProd=decimal.Parse(Console.ReadLine());
Console.WriteLine("La cantidad total del producto es?");
cant=int.Parse(Console.ReadLine());
importP= precioProd*cant;
Console.WriteLine("su importe total a pagar es:"+ importP);
Console.WriteLine("El cliente pago un total de:");
pago=decimal.Parse(Console.ReadLine());
cambio=Math.Abs(importP-pago);
Console.WriteLine("su cambio es:"+cambio);
