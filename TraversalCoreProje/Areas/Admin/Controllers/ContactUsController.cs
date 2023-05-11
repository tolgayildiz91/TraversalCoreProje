using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContacUsService _contacUsService;

        public ContactUsController(IContacUsService contacUsService)
        {
            _contacUsService = contacUsService;
        }

        public IActionResult Index()
        {
            var values = _contacUsService.TGetListContactUsByTrue();
            return View(values);
        }
    }
}
