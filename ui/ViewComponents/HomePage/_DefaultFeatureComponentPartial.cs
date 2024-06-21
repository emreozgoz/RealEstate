using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapperUI.ViewComponents.HomePage
{
	public class _DefaultFeatureComponentPartial : ViewComponent
	{
		//Burada metot ismine ahmet mehmet de diyebiliriz fakat gelenekselleşmiş bir isim olduğu için Invoke kullanırız
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
