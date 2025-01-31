using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Quiz
    {
        private List<QuizVraag> vragen;
        private List<QuizVraagAntwoord> ingevuldeAntwoorden;
        private const int aantalVragen = 10;

        public Quiz()
        {
            vragen = new List<QuizVraag>(new QuizVraag[aantalVragen]);
            ingevuldeAntwoorden = new List<QuizVraagAntwoord>(new QuizVraagAntwoord[aantalVragen]);
        }

        public void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            if (index >= 0 && index < vragen.Count)
            {
                vragen[index] = vraag;
            }
            else
            {
                Console.WriteLine("Index buiten bereik!");
            }
        }

        public void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            VoegVraagToeOpIndex(index, new QuizVraag(vraag, antwoord));
        }

        public void StelVraag(int index)
        {
            if (index < 0 || index >= vragen.Count || vragen[index] == null)
            {
                Console.WriteLine("Ongeldige index of vraag ontbreekt!");
                return;
            }

            Console.WriteLine(vragen[index].Vraag);
            string antwoord = Console.ReadLine();
            bool correct = string.Equals(antwoord.Trim(), vragen[index].Antwoord, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(correct ? "Goed!" : "Fout!");

            ingevuldeAntwoorden[index] = new QuizVraagAntwoord(vragen[index], correct);
        }

        public int BerekenScore()
        {
            int score = 0;
            foreach (var vraagAntwoord in ingevuldeAntwoorden)
            {
                if (vraagAntwoord != null && vraagAntwoord.IsCorrect)
                {
                    score++;
                }
            }
            return score;
        }
    }

    class QuizVraag
    {
        public string Vraag { get; }
        public string Antwoord { get; }

        public QuizVraag(string vraag, string antwoord)
        {
            Vraag = vraag;
            Antwoord = antwoord;
        }
    }

    class QuizVraagAntwoord
    {
        public QuizVraag Vraag { get; }
        public bool IsCorrect { get; }

        public QuizVraagAntwoord(QuizVraag vraag, bool isCorrect)
        {
            Vraag = vraag;
            IsCorrect = isCorrect;
        }
    }

    class Quizz
    {
        static void Main()
        {
            Quiz quiz = new Quiz();

            // Voeg vragen toe aan de quiz met beide methoden
            quiz.VoegVraagToeOpIndex(0, new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam"));
            quiz.VoegVraagToeOpIndex(1, "Wat is 2 + 2?", "4");
            quiz.VoegVraagToeOpIndex(3, "Hoeveel dagen heeft een week?", "7");
           

            // Loop alle vragen door en stel ze
            for (int i = 0; i < 10; i++)
            {
                quiz.StelVraag(i);
            }

            // Bereken en toon de score
            int score = quiz.BerekenScore();
            Console.WriteLine($"Je score is: {score}/10");
        }
    }
}

