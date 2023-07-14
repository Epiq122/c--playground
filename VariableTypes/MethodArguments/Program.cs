var rectangle = new Rectangle(100, 200);
Console.WriteLine($"reactanngle height before method : {rectangle.Height}");

MethodParameters.ChangeHeight(ref rectangle); // changes the value of the rectangle using the ref keyword
Console.WriteLine($"reactanngle height after method : {rectangle.Height}");

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