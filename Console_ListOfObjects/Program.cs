using System;
using System.Collections.Generic;

namespace Console_ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<People>();
            DisplayMenuScreen(students);
        }

        /// <summary>
        ///  Method to add people/students to the list as objects
        /// </summary>
        /// <param name="students">List of student objects</param>
        /// <returns>list of people/students</returns>
        public static List<People> AddPeople(List<People> students)
        {


            bool addMore = false;
            while (!addMore)
            {
                People p1 = new People();
                Console.Clear();
                Console.Write("Please add a name: ");
                p1.Name = Console.ReadLine();


                bool isValidInt;
                do
                {
                    Console.Write("Please enter an age (ex: 28): ");
                    isValidInt = int.TryParse(Console.ReadLine(), out int age);
                    if (!isValidInt)
                    {
                        Console.WriteLine("Please enter a valid integer.");
                    }
                    else
                    {
                        p1.Age = age;
                    }

                } while (!isValidInt);


                Console.Write("Is Active (yes or no): ");
                string userResponse = Console.ReadLine().ToLower();
                if (userResponse == "yes")
                {
                    p1.isActive = true;
                }
                else
                {
                    p1.isActive = false;
                }


                foreach (var item in Enum.GetValues(typeof(Demographic)))
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                bool isValidEnum;
                do
                {
                    Console.Write("Please enter the persons demographic: ");

                    isValidEnum = Enum.TryParse(Console.ReadLine(), out Console_ListOfObjects.Demographic demo);

                    if (!isValidEnum)
                    {
                        Console.WriteLine("Sorry, not a valid response, please try again.");
                    }
                    else
                    {
                        p1.demo = demo;
                    }
                } while (!isValidEnum);


                students.Add(p1);

                Console.Write("Would you like to add another?");
                userResponse = Console.ReadLine().ToLower();

                if (userResponse == "yes")
                {
                    addMore = false;
                }
                else
                {
                    addMore = true;
                }
            }
            return students;
        }

        /// <summary>
        /// Displays the people to the screen
        /// </summary>
        /// <param name="students">List of student objects</param>
        public static void DisplayPeople(List<People> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Demographic: " + item.demo);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Displays main menu screen
        /// </summary>
        /// <param name="students">List of student objects</param>
        static void DisplayMenuScreen(List<People> students)
        {
            bool quitApplication = false;
            string menuChoice;

            do
            {
                Console.Clear();
                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Add People");
                Console.WriteLine("\tb) View People");
                Console.WriteLine("\tc) ");
                Console.WriteLine("\td) ");
                Console.WriteLine("\te) ");
                Console.WriteLine("\tf) ");
                Console.WriteLine("\tq) Quit");
                Console.Write("\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        students = AddPeople(students);
                        break;

                    case "b":
                        Console.Clear();
                        DisplayPeople(students);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":

                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a letter for the menu choice.");

                        break;
                }


            } while (!quitApplication);
        }


    }
}
