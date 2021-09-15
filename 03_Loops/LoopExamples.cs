using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        //While, For, Foreach, Do While
        [TestMethod]
        public void WhileLoops()
        {
            // while (condition (true or false)) { Body of code that will be looped } If condition is true, condition will continue to run

            int counter = 1;

            while (counter != 10)
            {
                Console.WriteLine(counter);
                counter = counter +1;
                //More effecient way of running:
                //counter += 1;
                //counter ++;
            }

            counter = 1;

            while(true) //since stating true will continue to run forever until you set a breaking point.
            {
                Console.WriteLine(counter);
                if(counter == 7)
                {
                    Console.WriteLine("Goal reached.");
                    break;
                }

                counter++;
            }

            Random rng = new Random();
            bool isRunning = true;
            int someCount;

            while(isRunning)
            {
                //0 (inclusive) 21 (not inclusive) so random number between 0 and 20
                someCount = rng.Next(0, 21);

                if(someCount == 13 || someCount < 5)
                {
                    //continues the loop without progressing in code
                    continue;
                }

                Console.WriteLine(someCount);

                if(someCount == 17)
                {
                    //Exit Condition
                    isRunning = false;
                }
            }

        }

        [TestMethod]
        public void ForLoops()
        {
            //1 for Keyword
            //2 Starting Point
            //3 Condition to continue looping
            //4 What to do after each loop
            //5 Body of code to loop through

            int targetNumber = 21;

            //1     //2     //3             //4
            for(int i =0; i < targetNumber; i++)
            {
                //5
                Console.WriteLine(i);
            }

            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethan" };

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Good Morning {students[i]}");
            }
            
        }

        [TestMethod]
        public void ForeachLoops()
        {
            //1 foreach keyword
            //2 type of the collection (string, int, etc)
            //3 name of the current iteration
            //4 in keyword seperate the individual item and the collection
            //5 collectin being iterated through
            //6 body of the code to loop through

            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethan" };

            // 1    //2     //3       //4     //5
            foreach(string studentName in students)
            {
                //6
                Console.WriteLine(studentName + " is in class today");
            }

            string myName = "Mitch Pickard";
            foreach(char letter in myName)
            {
                //Space is considered a character so to run code with no spaces between the names: following;
                //If wanted space between names dont run the following:
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            // Do while loops always run at lease once
            //1 "do" keyword
            //2 Body of code to loop
            //3 while keyword
            //4 condition to continue looping

            int counter = 0;

            //1
            do
            {
                //2
                Console.WriteLine("Hello " + counter);
                counter++;
            }
            //3         //4
            while (counter < 5);
        }

        //goto keyword - goes to a specific line in code
    }
}
