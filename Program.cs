namespace Sololearn_3sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0) Console.WriteLine("Equal to 0");
            else if (x < 0) Console.WriteLine("Less 0");
            else Console.WriteLine("More 0");
        }
    }
}