namespace Task1
{
    using System;
    using System.Collections.Generic;

    class Path
    {
        private const string Separator = "\n";

        private readonly List<Point3D> sequenceOfPoints = new List<Point3D>();

        public Path(params Point3D[] sequenceOfPoints)
        {
            this.Add(sequenceOfPoints);
        }

        public int Count
        {
            get
            {
                return this.sequenceOfPoints.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return this.sequenceOfPoints[index];
            }
            set
            {
                this.sequenceOfPoints[index] = value;
            }
        }

        public void Add(params Point3D[] sequenceOfPoints)
        {
            foreach (var point in sequenceOfPoints)
            {
                this.sequenceOfPoints.Add(point);
            }
        }

        public void Remove(Point3D point)
        {
            this.sequenceOfPoints.Remove(point);
        }

        public void Clear()
        {
            this.sequenceOfPoints.Clear();
        }

        public override string ToString()
        {
            return string.Join(Separator, this.sequenceOfPoints);
        }
    }
}
