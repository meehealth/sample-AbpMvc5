using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AbpMvc5.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpMvc5ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}