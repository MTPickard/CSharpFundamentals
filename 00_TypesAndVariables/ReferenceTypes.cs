using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            //String is a colloction of characters. Characters are single letters.
            //Declaration
            string thisIsDeclaration;

            //Initialization
            thisIsDeclaration = "This is initialization";

            //Declaration and initialization same line
            string declarationAndInitialization = "This does both.";

            string singleLetter = "a";

            string firstName = "Mitch";
            string lastName = "Pickard";

            //Concatenation
            string concatenationFullName = (firstName + " " + lastName);

            //Composite formatting
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //Interpolation
            string interpolationFullName = $"{firstName} {lastName}";

            Console.WriteLine(concatenationFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolationFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";

            //Arrays are assigned the size at beggining, after not able to change size
            string[] stringArray = { "Hello", "What", "Why", "When", stringExample };

            string[] threeSpaces = new string[3];

            Console.WriteLine(stringArray[4]);

            stringArray[4] = "World";

            Console.WriteLine(stringArray[4]);

            //Lists are similiar to Arrays but you can add items as you go. Array has a fixed amount once you write the code.
            //to assign Using Statment click inside the word list use "control ." and select using statement.
            List<string> listOfStrings = new List<string>();
            List<int> listOfNumbers = new List<int>();

            listOfStrings.Add("Hello");
            listOfStrings.Add("Two");

            Console.WriteLine(listOfStrings[0]);

            int a = 5;
            int b = a;

            a = 7;

            Console.WriteLine(a + " " + b);

            listOfNumbers.Add(a);
            listOfNumbers.Add(b);

            List<int> secondListOfNumber = listOfNumbers;

            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumber[0]);

            listOfNumbers[0] = 13;
            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumber[0]);

            string firstName = "Mitch";
            string lastName = firstName;
            lastName = "Pickard";
            Console.WriteLine($"{ firstName} { lastName}");

            //Queues
            //First In First Out
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm second");

            Console.WriteLine(firstInFirstOut.Dequeue());
            Console.WriteLine(firstInFirstOut.Dequeue());

            //Stacks
            //Last In First Out
            Stack<string> lastInFirstOut = new Stack<string>();
            lastInFirstOut.Push("I'm first");
            lastInFirstOut.Push("I'm second");

            Console.WriteLine(lastInFirstOut.Pop());
            Console.WriteLine(lastInFirstOut.Pop());


            //Dictionaries
            Dictionary<string, string> dictionaryExample = new Dictionary<string, string>();

            dictionaryExample.Add("Bee", "Pointy string ouchy");

            string bee = dictionaryExample["Bee"];
            Console.WriteLine(bee);

            Dictionary<int, string> numberDictionary = new Dictionary<int, string>();
            numberDictionary.Add(7, "Bond");

            Console.WriteLine(numberDictionary[7]);
            numberDictionary.Add(-777, "Unlucky");
            Console.WriteLine(numberDictionary[-777]);

            //Linked Lists - Contains value and pointer to next list item
            //HashSet - Stores UNIQUEvalues (AKA if it has 7 stored cannot store 7 again)
        }

        [TestMethod]
        public void Classes()
        {
            Random  rng = new Random();

            int randomNumber = rng.Next(0, 10);

            Console.WriteLine(randomNumber);
        }
    }
}
