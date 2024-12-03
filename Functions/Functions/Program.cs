using System.Runtime.InteropServices;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            //het maakte een funtie genaamd new program, de variabelen zijn Program. 

        }
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            vraag();

        }
        internal void vraag()
        {
            Console.WriteLine("How long do you think you would survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);




        }
        

    }
}
