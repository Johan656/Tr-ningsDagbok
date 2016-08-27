using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public class Algorithms
    {
        public void plusMinus()
        {
            // variabler som representerar värden > 0, < 0 och 0
            double posValue = 0;
            double negValue = 0;
            double zeroValue = 0;

            // Definera en array
            int[] arr = { -4, 3, -9, 0, 4, 1 };

            // Loopa igenom arrayn
            for (int i = 0; i < arr.Length; i++)
            {
                // Checka om värderna i arrayn är > 0, < 0 eller 0;
                if (arr[i] > 0)
                {
                    posValue++;
                }
                else if (arr[i] < 0)
                {
                    negValue++;
                }
                else
                {
                    zeroValue++;
                }
            }

            // Skriv ut svaren i konsolen.
            Console.WriteLine(posValue / arr.Length);
            Console.WriteLine(negValue / arr.Length);
            Console.WriteLine(zeroValue / arr.Length);
            Console.ReadLine();
        }



        public void diagonalDifference()
        {
            int[,] grid = { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            //11,2,4
            //4,5,6
            //10,8,-12

            int sum1 = 0;

            int sum2 = grid[0, 2] + grid[1, 1] + grid[2, 0];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        try
                        {
                            sum1 += grid[i, j];
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
            }



            int difference = sum2 - sum1;

            Console.WriteLine(difference);
            Console.ReadLine();

        }




        public void bigSum()
        {
            double[] arr = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            double sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public void compareTripplets()
        {

            int[] tokens_a0 = { 5, 6, 7 };
            int[] tokens_b0 = { 3, 6, 10 };

            //The Points Variables
            int alicePoints = 0;
            int marksPoints = 0;
            // Alice
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            // Mark
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            // First Comparison 
            if (a0 > b0)
            {
                alicePoints += 1;
            }
            else if (a0 < b0)
            {
                marksPoints += 1;
            }

            // Second Comparison
            if (a1 > b1)
            {
                alicePoints += 1;
            }
            else if (a1 < b1)
            {
                marksPoints += 1;
            }

            // Third Comparison

            if (a2 > b2)
            {
                alicePoints += 1;
            }
            else if (a2 < b2)
            {
                marksPoints += 1;
            }

            Console.WriteLine(alicePoints + " " + marksPoints);
            Console.ReadLine();
        }


        public void sumArray()
        {
            int[] arr = { 1, 2, 3, 4, 10, 11 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    sum += arr[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ett fel uppstod!: " + ex);
                }

            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
