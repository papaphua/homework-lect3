using homework_lect3.Models;

namespace homework_lect3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CustomFuncs.CalculateFibonacci(2);
            foreach (var i in list) {
                Console.WriteLine(i);
            }
        }
    }
}