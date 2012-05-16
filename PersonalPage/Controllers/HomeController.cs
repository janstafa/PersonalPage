using System.Web.Mvc;
using Autofac;
using PersonalPage.Library.Helpers;
using PersonalPage.Models;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComponentContext _componentContext;

        public HomeController(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var serviceRecordModel = _componentContext.Resolve<ServiceRecordModel>();

            var serviceRecords = serviceRecordModel.GetAllServiceRecords();

            ViewBag.ServiceRecords = serviceRecords;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";



            return View();
        }



        public ActionResult Development()
        {
            ViewBag.Message = "Development";



            return View();
        }



        public ActionResult Portfolio()
        {
            ViewBag.Message = "Portfolio";



            return View();
        }



        public ActionResult Methodology()
        {
            ViewBag.Message = "Methodology";



            return View();
        }

    }
}
