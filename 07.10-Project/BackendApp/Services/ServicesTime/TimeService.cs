using System;

namespace BackendApp.Services.ServicesTime
{
    public class TimeService : ITimeService
    {
        public string GetTimeFull()
        {
            return DateTime.Now.ToString("dd.MM.yyyy  hh:mm:ss");
        }
        public string GetTimeDate()
        {
            return DateTime.Now.ToString("dd.MM.yyyy");
        }
        public string GetTimeHour()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }

        /* public string TimeFull { get; set; }
         public string TimeDate { get; set; }
         public string TimeHour { get; set; }
         public TimeService()
         {
             TimeFull = DateTime.Now.ToString("dd.MM.yyyy  hh:mm:ss");
             TimeDate = DateTime.Now.ToString("dd.MM.yyyy");
             TimeHour = DateTime.Now.ToString("hh:mm:ss");
         }*/

        /* class TimeProperty
         {
             public string TimeFull { get; set; }
             public string TimeDate { get; set; }
             public string TimeHour { get; set; }
     }
     public TimeProperty GetTime ()
     {
            return new TimeProperty()
             {
                 TimeFull = DateTime.Now.ToString("dd.MM.yyyy  hh:mm:ss"),
                 TimeDate = DateTime.Now.ToString("dd.MM.yyyy"),
                 TimeHour = DateTime.Now.ToString("hh:mm:ss"),
             };*/
    }
}
