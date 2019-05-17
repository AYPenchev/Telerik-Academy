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

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public static Point3D O { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} - x coordinate\n{1} - y coordinate\n{2} - z coordinate\n ", this.X, this.Y, this.Z); 
        }
    }
}
