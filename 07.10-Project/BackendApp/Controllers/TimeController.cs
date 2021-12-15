using Microsoft.AspNetCore.Mvc;
using BackendApp.Services.ServicesTime;

namespace BackendApp.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TimeController : Controller
    {
        private readonly ITimeService _timeService;
        public TimeController(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string GetTimeFull()
        { return _timeService.GetTimeFull(); }

        public string GetTimeDate()
        { return _timeService.GetTimeDate(); }
        public string GetTimeHour()
        { return _timeService.GetTimeHour(); }

        /*        [HttpGet]
                public string Time()
                {
                    ITimeService timeService = HttpContext.RequestServices.GetService<ITimeService>();
                    return timeService.TimeFull;
                }*/
    }
}
