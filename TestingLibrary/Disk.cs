using System;
using static System.Math;

namespace TestingLibrary
{
    public class Disk : PlanarShape
    {
        private double radius;

        /// <summary>
        /// Радиус круга
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public double Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Radius), "Radius of disk must be greater then zero.");

                radius = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public Disk(double radius = 0) => Radius = radius;

        public override double GetArea() => PI * Radius.InPower(2);
    }
}
