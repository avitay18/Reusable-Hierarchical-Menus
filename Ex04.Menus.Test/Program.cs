using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu menuWithInterface = ImplementWithInterfaces.CreateNewMenu();
            menuWithInterface.Show();

            Delegates.MainMenu menuWithDelegates = ImplementWithDelegates.CreateNewMenu();
            menuWithDelegates.Show();
        }
    }
}
