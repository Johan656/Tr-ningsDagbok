using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class DaysOfCode
    {

        public void daySixOfCode()
        {
            string[] input = Console.ReadLine().Split(' '); 

            string input1 = input[0];
            string input2 = input[1];

            string result1 = string.Empty;
            string result2 = string.Empty;
            string result3 = string.Empty;
            string result4 = string.Empty;

            for (int i = 0; i < input1.Length; i++)
            {
                input1.Split();

                if (i % 2 == 0)
                {
                    result1 += input1[i];
                }
                else
                {
                    result2 += input1[i];
                }
                
            }

            for (int i = 0; i < input2.Length; i++)
            {
                input2.Split();

                if (i % 2 == 0)
                {
                    result3 += input2[i];
                }
                else
                {
                    result4 += input2[i];
                }

            }

            Console.WriteLine(result1 + " " + result2);
            Console.WriteLine(result3 + " " + result4);
            Console.ReadLine();

        }

        public void dayFiveOfCode()
        {
            int N = 2;

            for (int i = 1; i <= 10; i++)
            {                
                Console.WriteLine(N + " x " + i + " = " + (N*i));
            }

            Console.Read();

        }

        public void dayFourOfCode()
        {
            // Done
        }

        public void dayThreeOfCode()
        {
            int n = 4;

            if (n % 2 != 0)
            {
                Console.WriteLine("Wierd");
            }
            else if (n % 2 == 0 && n >= 2 && n >= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (n % 2 == 0 && n >= 6 && n <= 20)
            {
                Console.WriteLine("Wierd");
            }
            else if (n % 2 == 0 && n > 20)
            {
                Console.WriteLine("Not Wierd");
            }

            Console.ReadLine();
        }

        public void dayTwoOfCode()
        {
            double mealCost = double.Parse(Console.ReadLine());
            int tip = int.Parse(Console.ReadLine());
            int tax = int.Parse(Console.ReadLine());

            double tipPercent = mealCost * tip / 100;
            double taxPercent = mealCost * tax / 100;

            Console.WriteLine("The total meal cost is " + Math.Round(mealCost + tipPercent + taxPercent) + " dollars.");
            Console.ReadLine();
        }

        public void dayOneOfCode()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int intNr = 0;
            double doubleNr = 0.0;
            string txt = "is the best place to learn and practice coding!";

            // Read and save an integer, double, and String to your variables.
            intNr = int.Parse(Console.ReadLine());
            doubleNr = double.Parse(Console.ReadLine());
            txt = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + intNr);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(d + doubleNr + ".0");

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

            Console.WriteLine(s + " " + txt);
            Console.ReadLine();
        }
    }
}
