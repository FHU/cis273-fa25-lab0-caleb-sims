namespace Vector;

public struct Vector
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Magnitude
    {
        get
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    public double Direction
    {
        get
        {
            return Math.Atan2(Y, X) * 180/Math.PI;
        }
    }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }


    // Instance methods 
    public Vector Add(Vector v)
    {
        Vector result = new Vector();
        result.X = this.X + v.X;
        result.Y = this.Y + v.Y;
        return result;
    }
    public Vector Subtract(Vector v)
    {
        Vector result = new Vector();
        result.X = this.X - v.X;
        result.Y = this.Y - v.Y;
        return result;
    }
    public double Dot(Vector v)
    {
        return 0.0;
    }
    public double AngleBetween(Vector v)
    {
        return 0.0;
    }

    public Vector Multiply(double scalar)
    {
        return default;
    }

    public Vector Divide(double scalar)
    {
        return default;
    }

    public Vector Normalize()
    {
        return default;
    }

    // Class (static) methods 
    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector Subtract(Vector v1, Vector v2)
    {
        return default;
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return 0.0;
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return default;
    }

     public static Vector Multiply(Vector v, double scalar)
    {
        return default;
    }

    public static Vector Divide(Vector v, double scalar)
    {
        return default;
    }

    public static Vector Normalize(Vector v)
    {
        return default;
    }

    // Overloaded operators 
    public static Vector operator +(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return default;
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return 0.0;
    }

    public static Vector operator *(Vector v1, double scalar)
    {
        return default;
    }

     public static Vector operator /(Vector v1, double scalar)
    {
        return default;
    }


}