using static System.Console;
using FirstLibrary;

namespace ConsoleApp1
{

    public class MainCls
    {
        public static void Main(string[] args)
        {
            var panda1 = new Panda("Pan Dee");
            var panda2 = new Panda("Pan Dah");
            WriteLine($"{panda1} {panda2} \n\tTotal: {Panda.Population}");
            ReadKey();
        }
    }

}
