using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateMethods
    {
        public static void menuItemChosen_ShowDate(MenuItem i_MenuItem)
        {
            Console.WriteLine("The date today is: {0}", DateTime.Now.ToShortDateString());
            Screen.PressKeyToContinue();
        }

        public static void menuItemChosen_ShowTime(MenuItem i_MenuItem)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Screen.PressKeyToContinue();
        }

        public static void menuItemChosen_ShowVersion(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 22.1.4.8930");
            Screen.PressKeyToContinue();
        }

        public static void menuItemChosen_CountCapitals(MenuItem i_MenuItem)
        {
            Console.WriteLine("Please enter your sentence: ");
            string userSentence = Console.ReadLine();

            int count = 0;

            foreach (char c in userSentence)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} capitals in your sentence.{1}", count, Environment.NewLine);
            Screen.PressKeyToContinue();
        }

        public static void menuItemChosen_DisplayMenu(MenuItem i_MenuItem)
        {
            int userInput = -1;
            int itemCounter = 1;
            const int zero = 0;

            while (userInput != zero)
            {
                Console.Clear();
                Console.WriteLine(i_MenuItem.Title);

                foreach (MenuItem item in i_MenuItem.MenuItemList)
                {
                    Console.WriteLine("{0} -> {1}", itemCounter++, item.Title);
                }
                Console.WriteLine("{0} -> {1}", zero, i_MenuItem.PrevMenu == null ? "Exit" : "Back");

                userInput = GetValidUserRequest(zero, itemCounter - 1);

                if (userInput != zero)
                {

                    i_MenuItem.MenuItemList[userInput - 1].ItemChosen();
                }

                itemCounter = 1;
            }
        }
        public static int GetValidUserRequest(int i_MinNumber, int i_MaxNumber)
        {
            bool validInput;
            string message = string.Format("{0}Enter your request: ({1} to {2} or press '0' to Exit).", Environment.NewLine, i_MinNumber + 1, i_MaxNumber);
            Console.WriteLine(message);
            validInput = int.TryParse(Console.ReadLine(), out int UserChoose);

            while (!validInput || UserChoose > i_MaxNumber || UserChoose < i_MinNumber)
            {
                message = string.Format("Invalid input, please try again:(numbers from {0} to {1})", i_MinNumber + 1, i_MaxNumber);
                Console.WriteLine(message);
                validInput = int.TryParse(Console.ReadLine(), out UserChoose);
            }

            return UserChoose;
        }
    }
}
