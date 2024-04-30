using ZiggyRafiq.CodeExample05.ViewModels;

namespace ZiggyRafiq.CodeExample05.Components;

public class UIComponent
{
    public void Display()
    {
        // Implement UI component with accessibility features
        // For example, ensure proper use of alt text for images is support.

        // Ensure proper alt text for images
        ImageComponentViewModel imageConmpent = new ImageComponentViewModel
        {
            AltText = "Description of the image for screen readers",
            ImagePath = "ImagePath/dummy.jpg"
        };

    }
}