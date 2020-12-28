using System;
using System.Collections.Generic;
using System.Text;

namespace Consolulator
{
    class Calculator
    {
        public int value1;
        public int value2;
        public string operationName;
        public int Add()
        {
            return value1 + value2;
        }
        public int Subtract()
        {
            return value1 - value2;
        }

        public int Multiply()
        {
            return value1 * value2;
        }

        public int Divide()
        {
            return value1 / value2;
        }

        public void ValueSelecting()
        {
            Console.WriteLine("You are about to " + operationName + " Value 1 with Value 2 ");

            Console.WriteLine("Input Value of Value 1:");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Value of Value 2:");
            value2 = Convert.ToInt32(Console.ReadLine());
        }

        public void Interface()
        {
            Console.WriteLine("What Do You Like To Perform?");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");

            var want = Console.ReadLine();

            if (want.Equals("add") || want.Equals("1"))
            {
                operationName = "Add";
                ValueSelecting();
                Console.WriteLine("The answer is: " + Add());
            }
            else if (want.Equals("subtract") || want.Equals("2"))
            {
                operationName = "Subtract";
                ValueSelecting();
                Console.WriteLine("The answer is: " + Subtract());

            }
            else if (want.Equals("multiply") || want.Equals("3"))
            {
                operationName = "Multiply";
                ValueSelecting();
                Console.WriteLine("The answer is: " + Multiply());

            }
            else if (want.Equals("divide") || want.Equals("4"))
            {
                operationName = "Divide";
                ValueSelecting();
                Console.WriteLine("The answer is: " + Divide());

            }
            else
            {
                Console.WriteLine("Please Select a valid operation.. ");
                Interface();
            }

            Console.WriteLine("Want to perform some more operations?");
            Console.WriteLine("so,");
            Interface();
        }
        }
    }
