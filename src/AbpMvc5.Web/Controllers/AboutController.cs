using System.Web.Mvc;

namespace AbpMvc5.Web.Controllers
{
    public class AboutController : AbpMvc5ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}