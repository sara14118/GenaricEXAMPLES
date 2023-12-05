namespace GenaricEXAMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("sara");
            Print(23);
            Print(2.4);
            Print(true);
        }


        static void Print<T>(T val)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(val);
        }
    }
}