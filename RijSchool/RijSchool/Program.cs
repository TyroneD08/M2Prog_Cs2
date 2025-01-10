
namespace RijSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.run();
            


            Console.WriteLine("Hello, World!");

           
        }

        private void run()
        {
      
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H"
              kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };

            LesUur lesuur = new LesUur()
            {
                auto = auto1,
                rijleraar = rijleraar,


                tijd = 1130
            };

            Student student = new Student()
            {
                naam = "rio",
                leeftijd = 19,
            };



             LesPakket lespakket = new LesPakket()
             {
                 urenGekocht = 20,
                 urenVerbruikt = 40,
                 examenPogingen = 2,
                 automaat = true,

             };

               RijLeraar rijleraar = new RijLeraar()
            {
                   leeftijd = 30,
                   naam = "john",
                   zzp = false,
            };

            TheorieTest theorietest = new TheorieTest()
            {
                aantalFouten = 7,
                Fouten = true,
                gehaald = true,
                afnameDatum = DateTime.Now,
            };

            RijTest rijtest = new RijTest()
            {

                gehaald = true,
                afnameDatum = DateTime.Now,
            };


    }
}
