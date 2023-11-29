internal class Program
{
    private static void Main(string[] args)
    {
        int min = 1;
        int max = 100;
        int r = 0;
        Random rnd = new Random();
        r = rnd.Next(min, max + 1);
        Console.WriteLine(r);
         if (r <= 50)
         {
            Console.WriteLine("Se le asignara al grupo 1");
         }
         else
         {
            Console.WriteLine("Se le asignara al grupo 2 ");

         }
    }
}