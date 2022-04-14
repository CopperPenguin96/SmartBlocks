namespace SmartBlocks.Entities;

public class BoundingBox
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Z { get; set; }

    public BoundingBox(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}