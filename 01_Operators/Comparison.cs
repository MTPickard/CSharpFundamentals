using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int year = 2021;
            string name = "Mitch";

            //Equal ==
            bool equal = year == 2021;
            bool isThisBob = name == "Bob";
            Console.WriteLine(equal);
            Console.WriteLine(isThisBob);

            //Inequality !=
            bool notEqual = year != 2021;
            bool isNotBob = name != "Bob";
            Console.WriteLine(notEqual);
            Console.WriteLine(isNotBob);

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            //below equation shows false because two different lists storing data in different places
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            //below equation shows true because two different locations but its the storing the same value.
            bool listItemsAreEqual = (firstList[0] == secondList[0]);
            Console.WriteLine(listItemsAreEqual);

            //Greater
            bool twentyFirstCentury = year > 2000;

            //Less Than
            bool lessThan = year < 3000;

            //Greater or equal
            bool greaterOrEqual = year >= 2021;

            //Less or equal
            bool lessOrEqual = year <= 1990;

            bool trueValue = true;
            bool falseValue = false;


            //Or ||
            bool trueOrTrue = trueValue || trueValue; //true
            bool trueOrFalse = trueValue || falseValue; //true
            bool FalseOrTrue = falseValue || trueValue; //true
            bool falseOrFalse = falseValue || falseValue;  //false

            // And &&
            bool trueAndTrue = trueValue && trueValue; //true
            bool trueAndFalse = trueValue && falseValue; //false
            bool falseAndTrue = falseValue && trueValue; //false
            bool falseAndFalse = falseValue && falseValue; // false


        }
    }
}
