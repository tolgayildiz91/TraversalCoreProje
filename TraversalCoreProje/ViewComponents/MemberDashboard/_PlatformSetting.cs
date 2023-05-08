using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            return View();
        }
    }
}
