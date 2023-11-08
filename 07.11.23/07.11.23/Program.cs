using System;

namespace _07._11._23
{
    class Program
    {
        struct HW
        { 
            public string subject;
            public string HWdescription;
            public DateTime DueDate;
            public bool complete;

        }
        static void Main(string[] args)
        {
            HW[] diary = new HW[20];
            int HWcount = 0;
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine($"\nWelcome to your Homework Diary {username}!");
            Console.WriteLine("\nHit any key!");
            Console.ReadKey();
            Console.Write("\nWould you like to display the menu? (y/n) ");
            string displaymenuchoice = Console.ReadLine();


            while (displaymenuchoice != "n" && displaymenuchoice != "y")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection! Please press 'y' or 'n' ");
                Console.ForegroundColor= ConsoleColor.White;
                displaymenuchoice = Console.ReadLine();
            }
            if (displaymenuchoice == "n")
            {
                Console.Clear();
            }
            if (displaymenuchoice == "y")
            {
                DisplayMenu();
            }
            Console.ReadLine();
        }
        static int GetHW(ref HW[] diary)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("homework.txt");

            int HWcount = 0;

            while (file.EndOfStream == false)
            {
                HW ThisHW;
                ThisHW.subject = file.ReadLine();
                ThisHW.HWdescription = file.ReadLine();
                ThisHW.DueDate = DateTime.Parse(file.ReadLine());
                ThisHW.complete = bool.Parse(file.ReadLine());
                HWcount += 1;
                diary[HWcount] = ThisHW;              
            }
            file.Close();
            return HWcount;
        }
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~\nHOMEWORK MENU \n(1) View Homework \n(2) Add Homework \n(3) Complete Homework \n(4) Quit\n~~~~~~~~~~~~~~~~~~~~~~~~~");
            int MenuChoice = int.Parse(Console.ReadLine());

            if (MenuChoice == 1)
            {
                GetHW();
            }
            if (MenuChoice == 2)
            {

            }
            if (MenuChoice == 3)
            {

            }
            if (MenuChoice == 4)
            {
                Console.Clear();
            }

        }
        static void SaveHW()
        {
            
        }

    }
}
