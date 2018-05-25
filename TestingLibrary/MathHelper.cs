using static System.Math;

namespace TestingLibrary
{
    internal static class MathHelper
    {
        public static bool IsNear(this double x, double y, double eps = double.Epsilon) => Abs(x - y) <= eps;

        public static bool IsTriangleTriple(double a, double b, double c) => a + b >= c;

        public static bool IsPythagorianTriple(double a, double b, double c) => (a.InPower(2) + b.InPower(2)).IsNear(c.InPower(2));

        public static double InPower(this double @base, double degree) => Pow(@base, degree);
    }
}
