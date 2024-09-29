namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            bool entireLoop = true;
            int amountOfGuesses = 0;
            int randomNumber = rand.Next(1, 21);
            int guessForText = 5;
            // Console.WriteLine(randomNumber); Write out the generated number
            Console.WriteLine($"Välkommen!\nJag tänker på ett nummer.\nKan du gissa vilket?\nDu får {guessForText} försök");
            while (entireLoop)
            {

                Console.WriteLine("Gissa nummer:");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());
                guessForText--;
                amountOfGuesses++;

                if (amountOfGuesses == 5)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök, jag är inte ens förvånad hahaha noob");
                    entireLoop = false;
                }

                else if (guessedNumber < 1 || guessedNumber > 20)
                {
                    Console.WriteLine($"Din gisning: {guessedNumber}");
                    Console.WriteLine("Du skulle gissa mellan 1-20 kompis vafan, ja du får ett försök mindre nu, var med nästa gång");
                    Console.WriteLine($"Du har {guessForText} försök kvar");

                }

                else if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Wohoo! Du gjorde det! Vart imponerad att du lyckades.....");
                    Console.WriteLine($"Du klara det med {guessForText} kvar");
                    entireLoop = false;
                }

                else if (guessedNumber > randomNumber)
                {
                    string answer = AnswerToUser(guessedNumber, guessForText, "högt!");
                    Console.WriteLine(answer);
                }

                else
                {
                    string answer = AnswerToUser(guessedNumber, guessForText, "lågt!");
                    Console.WriteLine(answer);
                }


            }
        }

        static string AnswerToUser(int guessedNumber, int guessForText, string inputType)
        {
            return ($"Du gissade:{guessedNumber}\nHahaha fyfan komigen nu kompis du gissade för {inputType}\nDu har {guessForText} försök kvar komigen tänk lite nu");

        }
    }
}
