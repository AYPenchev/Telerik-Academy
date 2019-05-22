namespace Task1
{
    using System;

    struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);
        
        static Point3D()
        {
            o.X = 0;
            o.Y = 0;
            o.Z = 0;
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        public static Point3D O { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }
    }
}
