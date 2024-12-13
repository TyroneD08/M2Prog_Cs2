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

        string[] vragen = new string[] {
            "what arcade game was called Puckman in Japan?",
            "What 1997 N64 video game features James Bond and is named after the 1995 film?"
        };




        //Program

        internal void Run()
        {

            Console.WriteLine("Hello World");
            Vraag7();
        }

        internal string Vraag7()
        { 
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            return antwoord;
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

        internal string GetVraag(int VraagIndex)
        {

            return vragen[VraagIndex];
        }

        string vraag0 = GetVraag(0);


        internal string GetRandomvraag()
        {

            int random =  . . . ;
            return GetVraag(random);
        }


        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
           
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
        }

        static void AskRandomQuestion()
        {
         
            string question = GetRandomVraag();

           
            Console.WriteLine("Vraag: " + question);

            Console.Write("Antwoord: ");
            string answer = Console.ReadLine();

         
            Console.WriteLine("Je antwoord was: " + answer);
            Console.WriteLine();
        }

        static string GetRandomVraag()
        {
         
            string[] vragen = {
            "Wat is je favoriete kleur?",
            "Wat is je favoriete dier?",
            "Wat is je droom baan?",
            "Wat is je favoriete eten?"
        };


            Random random = new Random();
            int index = random.Next(vragen.Length);

        
            return vragen[index];
        }
}
