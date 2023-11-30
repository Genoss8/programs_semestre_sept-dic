using System.Diagnostics.CodeAnalysis;

double calif1;
double calif2;
double calif3;
double suma;
double prom;
Console.WriteLine("calificacion 1 del alumno es:");
calif1=double.Parse(Console.ReadLine());
Console.WriteLine("calificacion 2 del alumno es:");
calif2=double.Parse(Console.ReadLine());
Console.WriteLine("calificacion 3 del alumno es:");
calif3=double.Parse(Console.ReadLine());
suma=calif1+calif2+calif3;
prom=suma/3;
Console.WriteLine("El promedio del alumno es:"+prom);