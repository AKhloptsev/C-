using System;
using System.Drawing;

namespace ForTest
{
    public class Triangle
    {
        private PointF A, B, C, D;

        public Triangle(PointF _A, PointF _B, PointF _C, PointF _D)
        {
            A = _A;
            B = _B;
            C = _C;
            D = _D;
        }

        // calculate length between two points
        private float L(PointF a, PointF b)
        {
            return Convert.ToSingle(Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y)));
        }

        // calculate area
        private float S(float a, float b, float c)
        {
            float p = 0;
            p = (a + b + c) / 2;
            return Convert.ToSingle(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        // check there is a point in the triangle
        public bool Check(out float S1, out float S2, out float S3, out float S4)
        {
            S4 = S(L(A, B), L(A, C), L(B, C));
            S1 = S(L(A, B), L(A, D), L(B, D));
            S2 = S(L(D, B), L(D, C), L(B, C));
            S3 = S(L(A, D), L(A, C), L(D, C));
            if (Math.Abs(S4 - (S1 + S2 + S3)) <= 0.1f)
                return true;
            else
                return false;
        }
    }
}