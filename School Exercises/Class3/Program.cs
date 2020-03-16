using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 4
            //string[] arrayOfStrings = { "I'm", "an", "array", "of", "strings" };
            //for (int i = 0; i< arrayOfStrings.Length; i++)
            //{
            //    Console.WriteLine(arrayOfStrings[i]);
            //}

            //decimal[] arrayOfDecimals = { 0.5m, 12.9m, 0.7m, 1.6m, 24.2m};
            //for (int i =0; i < arrayOfDecimals.Length; i++)
            //{
            //    Console.WriteLine(arrayOfDecimals[i]);
            //}


            //Console.WriteLine("Enter five characters:");
            //string inputChars = Console.ReadLine();
            //char [] chars = inputChars.ToCharArray();
            //for(int i=0; i<chars.Length; i++)
            //{
            //    Console.WriteLine(" " +chars[i]);
            //}

            //bool[] trueOrFalse = new bool[5];
            //trueOrFalse[0] = true;
            //trueOrFalse[1] = false;
            //trueOrFalse[2] = false;
            //trueOrFalse[3] = true;
            //trueOrFalse[4] = true;
            //for(int i=0; i<trueOrFalse.Length; i++)
            //{
            //    Console.WriteLine(trueOrFalse[i]);
            //}

            //int[,] jaggedArray = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };

            //for(int i = 0;  i<jaggedArray.GetLength(0); i++)
            //{
            //    for(int j = 0; j<jaggedArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(jaggedArray[i,j]);
            //    }


            //}
            //Console.ReadLine();

            #endregion

            #region Exercise 5
            //int[] arrayOfNums = new int[5];
            //int sum = 0;
            //for (int i= 0; i<arrayOfNums.Length; i++)
            //{
            //    Console.WriteLine($"Enter {i} number:");
            //    string input = Console.ReadLine();
            //    int num;
            //    bool checkIfNum = int.TryParse(input, out num);
            //    if (checkIfNum)
            //    {
            //        sum = sum + num;
            //    }
            //    Console.WriteLine($"this is the sum:{sum}");
            //    Console.ReadLine();
            //}
            
            //Console.ReadLine();


            #endregion

            #region Fucking with arrays



            string[] people = { "Saso", "Tanja", "Komsiite" };
            Console.WriteLine("One of the people is: {0}", people[0]);

            object[] randomArray = { "Saso", 100, 29.9 };
            Console.WriteLine("Some of the elements: {0}", randomArray[2].GetType());
            Console.WriteLine("This is how many elements there are in the array: {0}", randomArray.Length);
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0}: value {1}", i, randomArray[i]);
            }

            string [,] randomNames = new string[2, 2] { { "Saso", "Tanja" }, { "Josif", "Slavica" } };
            Console.WriteLine("Random name: {0}", randomNames.GetValue(1,0));
            for(int i = 0; i<randomNames.GetLength(0); i++)
            {
                for (int j = 0; j < randomNames.GetLength(1); j++)
                    Console.Write("{0}" + ", ", randomNames[i,j]);
            }
            Console.WriteLine();

            int[] randomNums = { 2, 54, 88, 6, 1, 533, 44 };
            //Array.Sort(randomNums);
            //Array.Reverse(randomNums);
            //randomNums.SetValue(0, 1);
            //Console.WriteLine("54 is at index: {0}", Array.IndexOf(randomNums, 54));
            foreach (int n in randomNums)
            {
                Console.WriteLine("One of the numbers: {0}", n);
            }

            
            int[] srcArray = { 1, 2, 3 };
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach (int m in anotherArray)
            {
                Console.WriteLine("{0}", m);
            }

            long num1 = 12345;
            int num2 = (int)num1;
            Console.WriteLine("The first number is {0}, and the second number is also {1}", num1, num2);
            Console.WriteLine("The type of first number is {0}, and the type of the second number is {1}", num1.GetType(), num2.GetType());

            Console.ReadLine();


            #endregion
            #region Exercise 6
            string[] names = new string[5];
            for(int i = 0; i<names.Length; i++)
            {
                Console.WriteLine("Enter a name:");
                string inputName = Console.ReadLine();
                names[i] = inputName;
                Console.WriteLine("Would you like to enter another name? If yes, please press Y, if no, please press N!");
                string yOrN = Console.ReadLine();
                if (yOrN == "Y" || yOrN =="y")
                {
                    names[i] = inputName;

                    
                } 
                if (yOrN == "N" || yOrN == "n")
                {
                    Console.WriteLine("Obviously you don't want to enter anymore names. Goodbye!");
                    break;
                } else
                {
                    Console.WriteLine("Please press the proper key!");
                }
                
                
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names);
            Console.ReadLine();
            
            #endregion
        }
    }
}
