using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            // declared and initialize array grades
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 : {0} ", grades[0]);
            //Console.ReadKey();

            string input = Console.ReadLine();
            // assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0} ", grades[0]);
            Console.ReadKey();

            //another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();


            int[] nums = new int[10];
            //for loop array
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            //foreach loop array
            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k); counter++;
            }

            Console.ReadKey();

            //Create an array with 5 of your best friends
            //Create a foreach loop which greets all of them
            string[] myFriends = { "Micheal", "Wlad", "Ilija", "Andy", "Daniel" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", name);
            }

            Console.ReadKey();

            //////-------Multidimension Arrays-------

            // Declare 2D Array
            string[,] matrix;

            // Declare 3D Array
            string[,,] threeD;

            //initializing 2D Array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 }, // row 0
                { 4, 5, 6 }, // row 1
                { 7, 8, 9 }  // row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("(TRY TO ACCESS 7) value is {0}", array2D[2, 0]);
            Console.ReadKey();

            //initializing 3D Array

            string[,,] array3D = new string[,,]
            {//1D(Depth)width?
                {//2D(Height)
                    {"000", "001"},//3D(length)
                    {"010", "011" },
                    {"Hi There", "What's up" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry" }
                }
            };
            //another way to initialize array with multiple arrays + specify dimensions

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };
            //change four to chicken
            array2DString[1, 1] = "chicken";

            Console.WriteLine("The value is {0}", array2DString[1, 1]);
            Console.WriteLine("The value is {0}", array3D[1,0, 1]);
            Console.WriteLine("(Access Hi There)The value is {0}", array3D[0, 2, 0]);
            Console.WriteLine("(Access Last entry)The value is {0}", array3D[1, 2, 1]);
            Console.ReadKey();

            //how to know what or how many dimensions
            //Rank returns the amount of dimensions
            int dimensions = array2DString.Rank;

            //simple way to intitialize auto generated dimensions
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            /*ERROR initialization 
            int[,] array2D2;
            array2D2 = { { 1, 2 }, { 3, 4 } };
            */

            Console.WriteLine("The dimensions is {0}", dimensions);
            Console.ReadKey();
        }
    }
}