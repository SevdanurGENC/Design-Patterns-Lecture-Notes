using ProtoTypeDesignPattern.ProtoTypeDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var dailyMeetingMorning = new DailyMeeting()
                {
                    StartDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 08:00")),
                    EndDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 08:15")),
                    Location = "Versatil",
                    Materials = new List<string>
                {
                    "Projeksiyon Cihazı",
                    "Laptop",
                    "Sticker"
                },
                    Participants = new List<string>
                {
                    "Samet", "Bayram","Enes"
                },
                    OrderSummary = "Bu kısmın uzun hesaplamalar sonucunda oluştuğunu varsayalım"
                };

                var dailyMeetingNight = dailyMeetingMorning.Clone();
                var dailyMeetingNoon = dailyMeetingMorning.Clone();


                dailyMeetingNoon.StartDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 12:00"));
                dailyMeetingNoon.EndDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 12:15"));

                dailyMeetingNight.StartDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 16:00"));
                dailyMeetingNight.EndDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 16:15"));



                Console.WriteLine(string.Format("DailyMeetingMorning: {0} - {1}", dailyMeetingMorning.StartDate, dailyMeetingMorning.EndDate));
                Console.WriteLine(string.Format("DailyMeetingNoon: {0} - {1}", dailyMeetingNoon.StartDate, dailyMeetingNoon.EndDate));
                Console.WriteLine(string.Format("DailyMeetingNight: {0} - {1}", dailyMeetingNight.StartDate, dailyMeetingNight.EndDate));

                Console.ReadLine();
            } 
             
    }
}
