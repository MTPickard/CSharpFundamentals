using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            //1 assignment operator
                //1
            int a = 22;
            int b = 45;

            // Addition +
            int sum = a + b;

            // Subtraction
            int difference = a - b;

            // Multiplication *
            int multiplication = a * b;

            // Division / 
            int division = a / b;

            // Remainder %
            // Modulus
            int remainder = b % a; // returns 1

            DateTime now = DateTime.Now;

            DateTime otherTime = new DateTime(2100, 1, 21);

            TimeSpan timeSpan = otherTime - now;

            Console.WriteLine(timeSpan.Days);

            // Overflow

            byte number = 200;
            byte otherNumber = 60;
                               // Casting to a byte
            byte thirdNumber = (byte)(number + otherNumber);

            Console.WriteLine(thirdNumber); //byte maxes out at 255 so over flow starts from 0 leaving writeline results of 4. (0,1,2,3,4)




        }
    }
}
