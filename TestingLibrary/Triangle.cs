using System;
using System.Linq;
using static System.Math;

namespace TestingLibrary
{
    public class Triangle : PlanarShape
    {
        private const int NuberOfVertexes = 3;

        private readonly double[] sides = new double[NuberOfVertexes];

        public Triangle(params double[] sides)
        {
            if (sides.Length != NuberOfVertexes)
                throw new ArgumentException();

            var result = true;
            for (var i = 0; i < sides.Length; i++)
                result = result && MathHelper.IsTriangleTriple(sides[i], sides[(i + 1) % NuberOfVertexes], sides[(i + 2) % NuberOfVertexes]);

            if (!result)
                throw new ArgumentException();

            Array.Copy(sides, this.sides, NuberOfVertexes);
        }

        public override double GetArea()
        {
            var halfOfPerimeter = sides.Sum() / 2;
            var tmpValue = halfOfPerimeter;
            foreach (var side in sides)
                tmpValue *= halfOfPerimeter - side;
            return Sqrt(tmpValue);
        }

        public bool IsRight()
        {
            var result = false;
            for (var i = 0; i < sides.Length; i++)
                result = result || MathHelper.IsPythagorianTriple(sides[i], sides[(i + 1) % NuberOfVertexes], sides[(i + 2) % NuberOfVertexes]);
            return result;
        }
    }
}
