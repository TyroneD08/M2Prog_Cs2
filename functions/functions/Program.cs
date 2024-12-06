using System.ComponentModel.Design;
using System.Net.Security;
using static System.Net.Mime.MediaTypeNames;

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
            Vraag7();
        }

        internal void Vraag7()
        {

            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }


        internal void Vraag1()
        {



            Console.WriteLine(" If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag2()
        {



            Console.WriteLine(" What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }


        internal void Vraag3()
        {



            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag4()
        {



            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }


        internal void Vraag5()
        {



            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag6()
        {



            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

    }
}
