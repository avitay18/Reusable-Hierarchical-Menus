using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class ImplementWithDelegates
    {
        public static MainMenu CreateNewMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");
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

            mainMenu.TheMainMenu.DoActionWhenChosen += DelegateMethods.menuItemChosen_DisplayMenu;
            versionAndCapitals.DoActionWhenChosen += DelegateMethods.menuItemChosen_DisplayMenu;
            showDateOrTime.DoActionWhenChosen += DelegateMethods.menuItemChosen_DisplayMenu;
            countCapitals.DoActionWhenChosen += DelegateMethods.menuItemChosen_CountCapitals;
            showVersion.DoActionWhenChosen += DelegateMethods.menuItemChosen_ShowVersion;
            showDate.DoActionWhenChosen += DelegateMethods.menuItemChosen_ShowDate;
            showTime.DoActionWhenChosen += DelegateMethods.menuItemChosen_ShowTime;

            return mainMenu;
        }
    }
}
