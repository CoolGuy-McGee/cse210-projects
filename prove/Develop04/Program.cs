using System;

class Program
{
    /*
        Exceeding Requirements Notes:
        -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        (BreathingActivity.cs Lines 36-51) I created a more meaningful breathing animation that shows a period growing into an uppercase "O" to simulate inflating lungs.
        (BreathingActivity.cs Lines 54-69) I created a more meaningful breathing animation that shows an uppercase "O' shrinking into a period to simulate inflating lungs.

        (ReflectionActivity.cs Line 36) I created a seperate list for this activity so I could remove questions after they have been printed.
        (ReflectionActivity.cs Line 61) Removes the question from my temporary list, but keeps the master list intact.
        -------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */

    static int Menu()
    {
        int choice = 0;
        while (choice < 1 || choice > 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
        }
        return choice;
    }

    static void Bootstrapper(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breathe = new BreathingActivity();
            breathe.welcome();
            breathe.performActivity();
            breathe.goodbye();
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity();
            reflect.welcome();
            reflect.performActivity();
            reflect.goodbye();
        }
        else if (choice == 3)
        {
            ListingActivity list = new ListingActivity();
            list.welcome();
            list.performActivity();
            list.goodbye();
        }
        else if (choice == 4)
        {
            Environment.Exit(7);
        }
    }

    static void Main(string[] args)
    {
        string status = "running";
        while (status == "running")
        {
            Bootstrapper(Menu());
        }
    }
}