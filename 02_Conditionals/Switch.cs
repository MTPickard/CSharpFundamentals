using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum PastryTypes { Ecaile, Croissant, Cake, Cupcake }

        [TestMethod]
        public void SwitchCases()
        {
            int input = 22;

            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
                case 22:
                    Console.WriteLine("You skipped a few options");
                    break;
                default:
                    Console.WriteLine("You didnt pick any of the numbers");
                    break;
            }

            PastryTypes pastry = PastryTypes.Ecaile;

            switch(pastry)
            {
                case PastryTypes.Cake:
                    Console.WriteLine("That is $30");
                    break;
                case PastryTypes.Croissant:
                case PastryTypes.Ecaile:
                case PastryTypes.Cupcake:
                    Console.WriteLine("That is $4");
                    break;
            }
    }
    }
}
