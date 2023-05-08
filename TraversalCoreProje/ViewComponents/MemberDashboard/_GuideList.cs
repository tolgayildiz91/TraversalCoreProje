using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {

        GuideManager _guideManager = new GuideManager(new EfGuideDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _guideManager.TGetList();
            return View(values);
        }
    }
}
