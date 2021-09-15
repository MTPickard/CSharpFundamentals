using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Boolenas()
        {
            // Declaring a variable.
            bool isDeclare;

            //Initiallizing a variable.
            isDeclare = true;

            //Useing camelCase for variables (starts with lower case and every new word is Uppercase.)
            bool isDeclareAndInitialized = true;

            isDeclareAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            // To define a character use single quotes.
            char character = 'a';
            char symbol = '?';
            char number = '2';
            char space = ' ';
            char spacialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            //int short byte long int16 int32 int64
            //2 ^ 8. can only hold 256 number but 0 counts as a number so max is 255.
            byte byteExample = 255;

            //Allows to go negative 128 to positive 128 however since 0 counts towards a positive number positive will only go to 127
            sbyte sByteExample = -128;

            //2^16= 65536. half is positive other half is negative.
            short shortExample = 32767;
            Int16 anotherShortExample = -32768;

            //2^32
            int intMax = 2147483647;
            Int32 intMin = 214748348;
            //Unsigned allows all the numbers to be positive
            uint unSignedInt = 214748349;

            //2^64
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775807;
        }

        [TestMethod]
        public void Decimal()
        {
            //decimal double float
            float floatExample = 1.9238575f; //requires letter f after the number
            double doubleExample = 1.9238575651351551; //doesnt require character after number because this is used a default by c#
            decimal decimalExample = 1.164135545635450318443318351635612165265m; // requires m after number

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }


        //Enum
        enum PastryTypes { Ecaile, Croissant, Cake, Cupcake }
        [TestMethod]
        public void Enums()
        {
            PastryTypes myPastry = PastryTypes.Croissant;
            PastryTypes anotherOne = PastryTypes.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;

            DateTime today = DateTime.Today;

            DateTime specificDate = new DateTime(2021, 09, 14);

            DateTime todayTwo = today;

            //var changes type from the right side of the = sign. can be int, DateTime, etc.
            var variable = 32;
        }
    }
}
