using System;

namespace Challenge_367_Easy_Subfactorials
{
    class Program
    {
        ///// <summary>
        ///// Takes number of possibilities from user input and determines the derangement for the input. Prints the rounded derangement.
        ///// </summary>
        ///// <param name="args">Number of posibilities</param>

        //static void Main(string[] args)
        //{
        /////////////////////With User input///////////////////////////////////////////

        //string Input = "";
        //while (!Input.Equals("qqq"))
        //{

        //    //Get User input
        //    Input = Console.ReadLine();
        //    //Test to see if input is a int. If the input is a number than check to see if the number is greater than 1. If the input is not an int write to console
        //    //If the number is greater than 1 get the factorial of the number than divide by Eulers number.
        //    //If the number is less than 1 return 1
        //    if (Int32.TryParse(Input, out int UserInputInt))
        //        Console.Write("!{0} -> {1}\n", Input, UserInputInt > 1 ? Math.Round(GetFactorial(UserInputInt) / Math.E) : 0);
        //    else
        //        Console.WriteLine("Input was not a number");

        //}


        //////////////////////With file/////////////////////////////////////////////////////////
        //    System.Collections.Generic.List<string> Valuelist = new System.Collections.Generic.List<string>(System.IO.File.ReadAllLines("IntList.txt"));
        //    double HoldValue;
        //    foreach (var item in Valuelist)
        //    {
        //        if (double.TryParse(item, out HoldValue))
        //            Console.WriteLine("!{0} -> {1}", item, Math.Round(GetFactorial(HoldValue) / Math.E));
        //        else
        //            Console.WriteLine("Input is not a number");
        //    }
        //    Console.ReadKey();
        //}

        ///// <summary>
        ///// Get the Factorial of the passed double.
        ///// </summary>
        //private static readonly Func<double, double> GetFactorial = x => x == 1 ? 1 : x * GetFactorial(x - 1);









        /// <summary>
        /// GOLF CODE
        /// </summary>
        /// <param name="args">Number of posibilities</param>
        static void Main(string[] args)
        {
            System.Collections.Generic.List<string> VL = new System.Collections.Generic.List<string>(System.IO.File.ReadAllLines("IntList.txt"));
            foreach (var i in VL)
            {
                var x = double.TryParse(i, out double II) == true ? Math.Round(F(II) / Math.E) : -99;
                Console.WriteLine("!{0} -> {1}", i, x != -99 ? x.ToString() : "Input is not an number");

            }
            Console.ReadKey();
        }

        /// <summary>
        /// Get the Factorial of the passed double.
        /// </summary>
        private static readonly Func<double, double> F = x => x == 1 ? 1 : x * F(x - 1);



    }
}
