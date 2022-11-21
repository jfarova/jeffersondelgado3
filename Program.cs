internal class Program
{
    private static void Main(string[] args)
    {
       int num=1;
       while(num!=0){
        Console.WriteLine("ingrese numero");
        num=int.Parse(Console.ReadLine());
       }
       Console.WriteLine("finalizado");
    }
}