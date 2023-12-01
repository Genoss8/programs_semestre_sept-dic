decimal pesos;
decimal euro;
decimal dollar;
string tipoCambio;
decimal Cambio;
Console.WriteLine("Ingrese cantidad de pesos a cambiar");
pesos=decimal.Parse(Console.ReadLine());
Console.WriteLine("a que tipo de moneda quiere cambiar?");
tipoCambio=(Console.ReadLine());
switch (tipoCambio)
{
    case "dollar":
    Console.WriteLine("El precio del dollar es:$17.37");
    dollar=pesos / 17.37m;
    dollar=Math.Round(dollar, 2);
    Console.WriteLine("Sus pesos en dolares son:"+dollar);
    break;
    case "euro":
    Console.WriteLine("El precio del euro es:$18.95 ");
    euro=pesos / 18.95m;
    euro=Math.Round(euro, 2);
    Console.WriteLine("Sus pesos en euros son:"+euro);
    break;
    default:
    Console.WriteLine("corrige el texto");
    break;
}
