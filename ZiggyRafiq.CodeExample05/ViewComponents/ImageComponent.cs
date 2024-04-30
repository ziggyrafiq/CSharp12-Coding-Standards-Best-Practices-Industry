using Microsoft.AspNetCore.Mvc;
using ZiggyRafiq.CodeExample05.ViewModels;

namespace ZiggyRafiq.CodeExample05.ViewComponents;

public class ImageComponent : ViewComponent
{
    public IViewComponentResult Invoke(string imagePath, string altText)
    {
        var model = new ImageComponentViewModel
        {
            ImagePath = imagePath,
            AltText = altText
        };

        return View(model);
    }
}
