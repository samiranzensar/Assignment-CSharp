using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace interface_abstraction
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();
    }
    interface ISolid : IVolume, IArea
    { }
    abstract class Solid : ISolid
    {
        public double radius;
        public const double pi = 3.142;
        public abstract double Volume
        {
            get;
        }
        public abstract double SurfaceArea();
        //public Solid(double rad)
        //{
        //    radius = rad;
        //}
        public Solid(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

    }
    class Cylinder : Solid
    {
        double height;
        public override double SurfaceArea()
        {

            Console.WriteLine("Area of Cylinder is:");
            return 2 * pi * Radius * (Radius + height);
        }
        public override double Volume
        {
            get
            {

                Console.WriteLine("Volume of Cylinder is:");
                return pi * Radius * Radius * height;
            }
        }
        public Cylinder(double height, double radius) : base(radius)
        {
            Console.WriteLine("{0} and {1}", height, radius);
            Height = height;
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
    class Sphere : Solid
    {
        public override double SurfaceArea()
        {
            Console.WriteLine("Area of Sphere is:");
            return (4 / 3) * pi * Radius * Radius * Radius;
        }
        public override double Volume
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                Console.WriteLine("Volume of Sphere is:");
                return 4 * pi * Radius * Radius;
            }
        }
        public Sphere(double radius) : base(radius)
        {
            Console.WriteLine("{0}", radius);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder obj = new Cylinder(10, 12);
            Sphere obj1 = new Sphere(6);
            Console.WriteLine(obj.SurfaceArea());
            Console.WriteLine(obj.Volume); Console.WriteLine(obj1.SurfaceArea());
            Console.WriteLine(obj1.Volume);
        }
    }
}