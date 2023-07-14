var rect = new Rectangle(10, 20);

// for the readonly struct
var rect2 = new ImmutableRectangle(10, 20);
// ImmutableRectangle.Width = 30; // error



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


public readonly struct ImmutableRectangle
{
  public ImmutableRectangle(double width, double height)
  {
    Width = width;
    Height = height;
  }


  public double Width { get; init; }
  public double Height { get; init; }
}