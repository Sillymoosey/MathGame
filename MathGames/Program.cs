using System;
using System.ComponentModel;
using System.Xml.Schema;

// colabbed with jenny, angel and gus and also jack

namespace MathGames
{
    class Program
    {
        static Random r1 = new Random();
        static Random r2 = new Random();

        public static (int, int) Initialize()
        {

            Console.WriteLine("Welcom to Math Games!\n" +
                "To add, enter 1\n" +
                "To subtract, enter 2\n" +
                "To multiply enter 3\n" +
                "To divide, enter 4");
            int propType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of problems between 1 and 12:");
            int numProb = Convert.ToInt32(Console.ReadLine());
            return (propType, numProb);
        }
        public static int Add(int numProb)
        {
            int answer;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {

                int x = r1.Next(13);
                int y = r2.Next(13);
                int total = x + y;
                Console.WriteLine($"what is: {x} + {y}");
                answer = Convert.ToInt32(Console.ReadLine());
                if(answer == total)
                {
                    score++;
                }
                else
                {
                    Console.WriteLine($"You suck! No point! The right answer was {total}");
                }

            }
            return score;
        }
        public static int Subtract(int numProb)
        {

            int answer;
            int score = 0;
            int total;
            for (int i = 0; i < numProb; i++)
            {

                int x = r1.Next(13);
                int y = r2.Next(13);
                if (x > y)
                {
                    total = x - y;
                }
                else
                {
                    total = y - x;
                }
                Console.WriteLine($"what is: {x} - {y}");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == total)
                {
                    Console.WriteLine("Good Job!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"You suck! No point! The right answer was {total}");
                }

            }
            return score;
        }
        public static int Multiple(int numProb)
        {
            int answer;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {

                int x = r1.Next(13);
                int y = r2.Next(13);
                int total = x * y;
                Console.WriteLine($"what is: {x} x {y}");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == total)
                {
                    Console.WriteLine("Good Job!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"You suck! No point! The right answer was {total}");
                }

            }
            return score;
        }
        public static int Divide(int numProb)
        {
            double answer;
            int score = 0;
            for (int i = 0; i < numProb; i++)
            {

                double x = r1.Next(13);
                double y = r2.Next(13);
                double total = Math.Round(x/y, 2);
                Console.WriteLine($"what is: {x} / {y}");
                answer = Convert.ToDouble(Console.ReadLine());
                if (answer == total)
                {
                    Console.WriteLine("Good Job!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"You suck! No point! The right answer was {total}");
                }

            }
            return score;
        }
        public static string Report(int score, int numProb)
        {
            string total = Convert.ToString(score + numProb);
            return total;
        }
        static void Main(string[] args)
        {
            int probType = 0;
            int numProb = 0;
            int score = 0;
            (probType, numProb) = Initialize();
            if (probType == 1)
            {
                Console.WriteLine($"You are testing Add and you have {numProb}");
                Console.WriteLine("To begin you test press anyKey:");
                Console.ReadLine();
                score = Add(numProb);
            }
            else if (probType == 2)
            {
                Console.WriteLine($"You are testing subtract and you have {numProb}");
                Console.WriteLine("To begin you test press anyKey:");
                Console.ReadLine();
                score = Subtract(numProb);
            }
            else if (probType == 3)
            {
                Console.WriteLine($"You are testing Multiple and you have {numProb}");
                Console.WriteLine("To begin you test press anyKey:");
                Console.ReadLine();
                score = Multiple(numProb);
            }
            else if (probType == 4)
            {
                Console.WriteLine($"You are testing Divide and you have {numProb}");
                Console.WriteLine("To begin you test press anyKey:");
                Console.ReadLine();
                score = Divide(numProb);
            }
            else
                Console.WriteLine("Sorry, you made an invalide choice commrad.");
            //the end of the if else
            string report = Report(score, numProb);
            Console.WriteLine(report);
        }
    }
}
