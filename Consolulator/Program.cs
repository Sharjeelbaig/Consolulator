using System;

namespace Consolulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculate = new Calculator();
            try
            {
                calculate.Interface();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry,Please try again..");
                calculate.Interface();
            }



        }
    }
}
