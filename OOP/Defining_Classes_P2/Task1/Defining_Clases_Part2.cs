namespace Task1
{
    using System;

    class DefiningClasesPart2
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(1, 2, 3);
            Console.WriteLine(firstPoint.ToString());

            Point3D secondPoint = new Point3D(4, 5, 6);
            Console.WriteLine(secondPoint.ToString());

            double distance = DistanceToPoint.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine(distance + Environment.NewLine);

            Path path = new Path(firstPoint, secondPoint, new Point3D(4, 4, 4));
            Console.WriteLine(path);

            path.Add(new Point3D(5, 5, 5), new Point3D(3, 3, 3));
            Console.WriteLine(path);

            path.Remove(new Point3D(5, 5, 5));
            Console.WriteLine(path);

            PathStorage.SaveToFile(path);

            path.Clear();
            Console.WriteLine(path);

            Path newPath = new Path();
            newPath = PathStorage.LoadFromFile();
            Console.WriteLine(newPath);
        }
    }
}
