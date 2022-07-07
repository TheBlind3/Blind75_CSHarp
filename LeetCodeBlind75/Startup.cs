using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBlind75
{
    /// <summary>
    /// Quick static class to run console tests through/debugging. 
    /// </summary>
    static class Startup
    {
        static ArrayProblems problems = new ArrayProblems();

        /// <summary>
        /// Debug Console Test
        /// </summary>
        public static void ConsoleTest()
        {
           MaxProfitTest();
        }
        /// <summary>
        /// Method to Run Console Test By name
        /// </summary>
        /// <param name="TestName">Name of problem to run ConsoleTest for.</param>
        public static void ConsoleTest(string TestName)
        {
            TwoSumTest();
        }


        public static void TwoSumTest()
        {
            int[] x = problems.TwoSum(new int[4] { 2, 7, 11, 15 }, 9);
            Console.WriteLine("[" + x[0] + ", " + x[1] + "]");
        }
        public static void MaxProfitTest()
        {
            int x = problems.MaxProfit(new int[6] { 7, 1, 5, 3, 6, 4 });
            Console.WriteLine(x);
        }
    }
}
