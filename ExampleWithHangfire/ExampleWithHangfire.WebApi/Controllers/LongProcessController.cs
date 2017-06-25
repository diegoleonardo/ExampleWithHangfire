using Hangfire;
using System.Threading;
using System.Web.Mvc;

namespace ExampleWithHangfire.WebApi.Controllers
{
    public class LongProcessController : Controller
    {
        // GET: LongProcess
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            BackgroundJob.Enqueue(()=> Process());
            return View();
        }

        public void Process()
        {
            for (int index = 0; index < 2; index++)
            {
                Thread.Sleep(60000);
            }
        }
    }
}