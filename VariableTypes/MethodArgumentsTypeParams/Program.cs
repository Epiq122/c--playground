public struct Rectangle
{
  public Rectangle(double width, double height)
  {
    Width = width;
    Height = height;
  }


  public double Width { get; set; }
  public double Height { get; set; }
}

public class MethodParameters
{
  public static void ChangeHeight(ref Rectangle rectangle)
  {
    rectangle.Height = 500;
    Console.WriteLine($"reactanngle height in method : {rectangle.Height}");
  }
}