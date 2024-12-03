using System.ComponentModel.Design;
using System.Net.Security;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
      
        }
        //Program

        internal void Run()
        {

            Console.WriteLine("Hello World");
        }

        internal void Vraag1()
        {

            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();


            Console.WriteLine(antwoord);
        }  

    }
}
