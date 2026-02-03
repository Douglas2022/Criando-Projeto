using System;
using Couser.Device;

namespace Couser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner S = new Scanner() { SerialNumber = 2003};
            S.ProcessDoc("My Email");
            Console.WriteLine(S.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertatio");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
