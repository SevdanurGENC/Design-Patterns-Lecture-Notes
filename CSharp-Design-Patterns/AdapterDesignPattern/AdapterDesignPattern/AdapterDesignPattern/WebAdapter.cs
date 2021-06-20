using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.AdapterDesignPattern
{
    internal class WebAdapter : IEmail
    {
        private IWeb web;

        public WebAdapter(IWeb web)
        {
            this.web = web;
        }

        public void Send()
        {
            web.Push();
        }
    }
}
