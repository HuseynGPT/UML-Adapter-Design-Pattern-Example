using System.Net.Http.Headers;

interface IAdvancedImageViewer
{
    void ShowPng();
    void ShowJpg();

}


class PngShower : IAdvancedImageViewer
{
    public void ShowJpg()
    {
        // code
    }

    public void ShowPng()
    {
        // code

    }
}


class JpgShower : IAdvancedImageViewer
{
    public void ShowJpg()
    {
        // code
    }

    public void ShowPng()
    {
        // code

    }
}


interface IImageViewer
{
    void Show();
}

class ImageAdapter : IImageViewer
{
    private IAdvancedImageViewer AdvanceImageViewer;
    public ImageAdapter()
    {
        
    }
    public void Show()
    {
        Console.WriteLine("code");
    }
}


class GalleryApp : IImageViewer
{

    private ImageAdapter ımageAdapter;
    public void Show()
    {
        //codes
    }
}



