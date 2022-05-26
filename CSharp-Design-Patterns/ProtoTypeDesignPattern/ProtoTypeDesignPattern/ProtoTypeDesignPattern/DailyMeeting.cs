using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeDesignPattern.ProtoTypeDesignPattern
{
    class DailyMeeting : Meeting
    {
        public override Meeting Clone()
        {
            return (Meeting)this.MemberwiseClone();
            //this.MemberwiseClone() metodu .net frameworküne ait bir sınıftır. Belirtilen sınıfın kopyasını oluşturur.
        }
    }
}
