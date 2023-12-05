int pieProd;
int pieDef;
double porcScrap;
Console.WriteLine("cual es la cantidad de piezas producidas?");
pieProd=int.Parse(Console.ReadLine());
Console.WriteLine("cuantas piezas defectuosas hubo?");
pieDef=int.Parse(Console.ReadLine());
porcScrap=(pieDef*100)/pieProd;
Console.WriteLine("el porcentaje del rechazo es:"+ porcScrap);