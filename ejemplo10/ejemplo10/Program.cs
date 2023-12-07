int clientesDia=0;
string nombre;
int clientes=0;
Console.WriteLine("ingrese el nombre del siguiente cliente:");
nombre=Console.ReadLine();
if (clientes==0)
{
    clientes=1;
}

if (clientesDia==0)
{
    clientesDia=1;
}
clientesDia++;
Console.WriteLine("El numero de clientes del dia es:{0}"+clientesDia);
Console.WriteLine("El numero total de clientes es:{0}"+clientes);

