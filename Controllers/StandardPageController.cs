using EPiServer.Web.Mvc;
using max.Cms12.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace max.Cms12.Reference.Commerce.Site.Features.Shared.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}
