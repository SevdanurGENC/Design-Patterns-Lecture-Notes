using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeDesignPattern.ProtoTypeDesignPattern
{
    abstract class Meeting
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public List<string> Participants { get; set; }
        public List<string> Materials { get; set; }

        public object OrderSummary { get; set; } 
        public abstract Meeting Clone();

        //nesneyi koplayacak Clone adında metot oluşturuyorum. 
        //Bu metot miras alınan sınıflar tarafından oluşturulacağı için abstract olarak tanımlıyorum. 
        //Abstract metot olduğu için sınıfımı da abstract olarak tanımlıyorum.
    }
}
