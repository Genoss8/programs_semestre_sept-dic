string nombre;
int contador=0;
Console.WriteLine("ingrese nombre del  cliente:");
nombre=Console.ReadLine();  
while (nombre!="")
{
    contador=contador+1;
    Console.WriteLine("ingrese el nombre del siguiente cliente:");
    nombre=Console.ReadLine();
    Console.WriteLine("El numero de clientes es:"+ contador);
}
