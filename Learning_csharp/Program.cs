using System;
using System.Collections.Generic;

namespace Learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //challenge - create a simple three question survey//
            /*Console.WriteLine("what is your name?");
            string n=Console.ReadLine();
           while(n=="")
           {
               n = tryagain();
           }
            Console.WriteLine("how old are you?");
            string o = Console.ReadLine();
           while ( o== "")
           {
               o = tryagain();
           }
           Console.WriteLine("what month were you born in");
            string m = Console.ReadLine();
           while (m == "")
           {
               m = tryagain();
           }
           Console.WriteLine("your name is {0}",n);
            Console.WriteLine("you are {0} years old",o);
            Console.WriteLine("you were born in {0}",m);*/

            //challenge - passcode authentication//
            /*string passcode = "";
            while (passcode != "secret")
            {
                Console.WriteLine("Please enter the passcode");
                passcode = Console.ReadLine();          
                if (passcode != "secret")
                {
                    Console.WriteLine("Sorry, we dont recognise that passcode. Please try again");
                }
            }
           Console.WriteLine("You are authenticated");  */

            //loop counting//
            /*for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(j);
                }
                for (int j = 10; j >= 1; j--)
                {
                    Console.WriteLine(j);
                }
            }*/
            //initializing array and using foreach//
            /* var rohithgrades = new int[] {23,68,87 };
             foreach (var rohithgrade in rohithgrades)
             {
                 Console.WriteLine(rohithgrade);
             }*/

            // Challenge - Student Manager //
            /*            Console.WriteLine("How many student in the class?");
                        var count = int.Parse(Console.ReadLine());
                        var Student_Name = new string[count];
                        var Student_Grade = new int[count];
                        for(int i=0;i<count;i++)
                        {
                            Console.WriteLine("Please enter the student name");
                            Student_Name[i] = Console.ReadLine();
                            while (Student_Name[i] == "")
                            {
                                Console.WriteLine("You Did not enter anything, Please enter the student name again");
                                Student_Name[i]=Console.ReadLine();
                            }
                            Console.WriteLine("Please enter the student Grade");
                            Student_Grade[i] = int.Parse(Console.ReadLine());
                        }
                        for(int i=0;i<count;i++)
                        {
                            Console.WriteLine("Student Name:{0}  Student Grade:{1}", Student_Name[i], Student_Grade[i]);
                        }*/
            // Challenge - Student Manager using list //
            var StudentNames = new List<String>();
            var StudentGrades = new List<int>();
            var add = true;
            while(add)
            {
                Console.WriteLine("Please type the student name");
                StudentNames.Add(Console.ReadLine());
                Console.WriteLine("Please type the student grade");
                StudentGrades.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("If you want to add another student please type 'y', else type 'n'");

                if (Console.ReadLine() == "n")
                    add = false;
            }
            for(int i=0;i<StudentNames.Count;i++)
            {
                Console.WriteLine("Student Name:{0}  Student Grade:{1}", StudentNames[i], StudentGrades[i]);
            }

        }
        static string tryagain()
        {
            Console.WriteLine("you did not type anything, please try again:");
            return Console.ReadLine();
        }



    }
}
