using System;
namespace koord
{
    public class Circle
    {
        public int X, Y, Rad;

        public Circle(int x, int y, int rad)
        {
            X = x;
            Y = y;
            Rad = rad;
        }

        public double DistanceFromZero()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }


        public override string ToString()
        {
            return $"X: {X}; Y: {Y}; Rad: {Rad}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Circle))
                return false;

            Circle toCheck = obj as Circle;
            return ((toCheck.X == X) && (toCheck.Y == Y) && (toCheck.Rad == Rad));

        }

        public static bool CheckImpose(Circle a, Circle b)
        {
            int radSum = a.Rad + b.Rad;
            double centerDistance = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            return radSum > centerDistance;
        }

    }
}
