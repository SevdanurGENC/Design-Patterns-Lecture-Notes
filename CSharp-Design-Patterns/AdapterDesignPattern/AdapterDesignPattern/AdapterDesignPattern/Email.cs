using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.AdapterDesignPattern
{
    class Email: IEmail
    {
      public void Send()
            {
                Console.WriteLine("Sending email.");
            }

    }
}
