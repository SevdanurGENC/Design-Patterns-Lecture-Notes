using SingletonDesignPattern.SingletonDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DBHelper helper1 = DBHelper.CreateDBHelper("Test Connection");
            helper1.StateMessage = "Ornek bir mesaj";
            Console.WriteLine(helper1.StateMessage);

            DBHelper helper2 = DBHelper.CreateDBHelper("Another Test");
            Console.WriteLine(helper2.StateMessage);

            Console.ReadKey();
        }
    }
}
