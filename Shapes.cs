// Shapes - Class diagram
// Create a C# program that represents the following UML class diagram. 
// The diagram represents public, private, and protected attributes as well 
// as class dependency and inheritance.
public class Shape
{
    protected Location c;
 
    public string ToString()
    {
        return string.Empty;
    }
 
    public double Area()
    {
        return 0.000;
    }
 
    public double Perimeter()
    {
        return 0.000;
    }
}
 
public class Location
{
    private double x, y;
}
 
public class Rectangle : Shape
{
    protected double side1, side2;
}
 
public class Circle : Shape
{
    protected double radius;
}