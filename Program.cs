using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool cont = true;

         do {
            Console.WriteLine("Enter Integer  1-10");

            int output;
            string input = Console.ReadLine();
            output = int.Parse(input);

            int i = 1;
            long total = 1;

            for (i = 1; i <= output; i++)
            {
                total *= i;

            }
            Console.WriteLine("factorial of output =  " + total);


            Console.WriteLine("do you wish to continue y/n");
            string name;
            name = Console.ReadLine();
            name = name.ToLower();
            name = name.Trim();
            if (name == "y")
            {
                // Console.WriteLine("Hello,World");
                cont = true;
            }
            else
            {
                cont = false;
                Console.WriteLine("goodbye");

            }
          } while (cont == true);


        }




    }
            



}

//LAB NUMBER: 5
//Task: Calculate the factorial of a number.
//What will the application do?
//● The application prompts the user to enter an integer from 1 to 10.
//● The application displays the factorial of the number entered by the user.
//● The application prompts the user to continue.
//Build Specifications
//1. Use a for loop to calculate the factorial.
//2. Assume that the user will enter valid data.
//3. Use the long type to store the factorial.
//4. The application should continue only if the user agrees to.
//Hints:
//● A factorial is a number multiplied by each of the numbers before it. Factorials
//are denoted by the exclamation point (n!). Ex:
//o 1! = 1 which equals 1
//o 2! = 1 x 2 which equals 2
//o 3! = 1 x 2 x 3 which equals 6
//o 4! = 1 x 2 x 3 x 4 which equals 24
