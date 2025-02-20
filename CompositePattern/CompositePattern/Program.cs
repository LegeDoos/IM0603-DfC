using CompositePattern.Models;

namespace CompositePattern
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World! This is my Composite Pattern exercise!");

            SlideshowComponent slideshow = new Slideshow(); // creation?? factory??
            
            Slide slide = new();
            Item item = new();
            item.AddPart(new Text() { TheText = "Dit is tekst 1" });
            Item item2 = new();
            item2.AddPart(new Text() { TheText = "Dit is tekst 2" });
            Item item3 = new();
            item3.AddPart(new Figure() { Reference = "http://dsffsdfsdfsd" });
            slide.AddPart(item);
            slide.AddPart(item2);
            slide.AddPart(item3);
            slideshow.AddPart(slide);

            Slide slide2 = new();
            Item item21 = new();
            List list = new();
            Item listItem1 = new();
            listItem1.AddPart(new Text() { TheText = "Listitem 1 text" });
            Item listItem2 = new();
            listItem2.AddPart(new Text() { TheText = "Listitem 2 text" });
            Item listItem3 = new();
            listItem3.AddPart(new Text() { TheText = "Listitem 3 text" });
            Item listItem4 = new();
            listItem4.AddPart(new List());
            list.AddPart(listItem1);
            list.AddPart(listItem2);
            list.AddPart(listItem3);
            list.AddPart(listItem4);
            item21.AddPart(list);
            slide2.AddPart(item21);
            slideshow.AddPart(slide2);

            slideshow.Show();
        }
    }
}
