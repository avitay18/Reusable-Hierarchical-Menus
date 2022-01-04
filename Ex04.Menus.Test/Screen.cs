using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Screen
    { 
        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
