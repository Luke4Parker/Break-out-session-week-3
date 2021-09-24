using System;

namespace Break_out_session_week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curved Grade Calculator");

            Console.WriteLine("Enter Test Points: ");
            double testPoints = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Test 1 score: ");
            double testScore1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Test 2 score: ");
            double testScore2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Test 3 score: ");
            double testScore3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Test 4 score: ");
            double testScore4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Test 5 score: ");
            double testScore5 = double.Parse(Console.ReadLine());

            //Uses the Math.Max method to compare each test score against itself
            double max = Math.Max(testScore1, Math.Max(testScore2, Math.Max(testScore3, Math.Max(testScore4, testScore5))));

            //Uncurved Percentages
            double uncurved1 = 100 * (testScore1 / max);
            double uncurved2 = 100 * (testScore2 / max);
            double uncurved3 = 100 * (testScore3 / max);
            double uncurved4 = 100 * (testScore4 / max);
            double uncurved5 = 100 * (testScore5 / max);

            //Curved Percentagees
            double curved1 = 100 * (testScore1 / max);
            double curved2 = 100 * (testScore2 / max);
            double curved3 = 100 * (testScore3 / max);
            double curved4 = 100 * (testScore4 / max);
            double curved5 = 100 * (testScore5 / max);




            Console.WriteLine("Max = " + max);


            Console.WriteLine(testPoints + " " + testScore1 + " " + testScore2 + " " + testScore3 + " " + testScore4 + " " + testScore5);
            Console.WriteLine(testPoints + " " + curved1 + " " + curved2 + " " + curved3 + " " + curved4 + " " + curved5);

            //double max = Math.Max(testScore1, testScore2);
            //max = Math.Max(max, testScore3);
            //max = Math.Max(max, testScore4);
            //max = Math.Max(max, testScore5);
        }
    }
}
