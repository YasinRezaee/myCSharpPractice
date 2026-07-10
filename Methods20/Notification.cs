using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Notification
    {
        public static void ErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void WarningMessage(string message)
        {
            Console.WriteLine(message);
        }
}
}

