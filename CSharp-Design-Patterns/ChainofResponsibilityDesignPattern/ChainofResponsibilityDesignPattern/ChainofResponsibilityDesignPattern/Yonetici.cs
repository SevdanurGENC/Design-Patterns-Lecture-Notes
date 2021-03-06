using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern.ChainofResponsibilityDesignPattern
{
    public class Yonetici : Employee
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 70000)
            {
                Console.WriteLine("{0} tarafından para çekme işlemi onaylandı #{1} TL",
                    this.GetType().Name, req.Amount);
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("{0} TL işlem tutarı {1} max. limitini aştığından işlem yöneticiye gönderildi.", req.Amount, this.GetType().Name);

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
