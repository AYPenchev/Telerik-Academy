namespace Task1
{
    using System;
    struct Point3D
    {
        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} - x coordinate\n{1} - y coordinate\n{2} - z coordinate\n ", this.X, this.Y, this.Z); 
        }

    }
}
