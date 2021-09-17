using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Creative_Media_Project
{
    class TextChange
    {
        public static void ChangePrompt(string m, ConsoleColor B, ConsoleColor F)
        {
            Console.BackgroundColor = B;
            Console.ForegroundColor = F;
            Console.WriteLine(m);
            Console.ResetColor();
        }
    }
}
