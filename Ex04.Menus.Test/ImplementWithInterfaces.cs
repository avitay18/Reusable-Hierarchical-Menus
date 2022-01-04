using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ImplementWithInterfaces
    {
        public static MainMenu CreateNewMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");
            MenuItem versionAndCapitals = new MenuItem("Version and Capitals");
            MenuItem showDateOrTime = new MenuItem("Show Date/Time");
            MenuItem countCapitals = new MenuItem("Count Capitals");
            MenuItem showVersion = new MenuItem("Show Version");
            MenuItem showDate = new MenuItem("Show Date");
            MenuItem showTime = new MenuItem("Show Time");
            
            mainMenu.AddItem(versionAndCapitals);
            mainMenu.AddItem(showDateOrTime);
            versionAndCapitals.AddItem(countCapitals);
            versionAndCapitals.AddItem(showVersion);
            showDateOrTime.AddItem(showDate);
            showDateOrTime.AddItem(showTime);

            mainMenu.TheMainMenu.m_ItemAction = new DisplayMenu();
            versionAndCapitals.m_ItemAction = new DisplayMenu();
            showDateOrTime.m_ItemAction = new DisplayMenu();
            countCapitals.m_ItemAction = new CountCapitals();
            showVersion.m_ItemAction = new ShowVersion();
            showDate.m_ItemAction = new ShowDate();
            showTime.m_ItemAction = new ShowTime();

            return mainMenu;
        }
        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }
}
