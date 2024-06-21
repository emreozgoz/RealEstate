using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial : ViewComponent
    {
        //View componentlere url üzerinden erişim sağlanamaz
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
