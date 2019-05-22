namespace Task1
{
    using System;
    using System.Linq;
    using System.Reflection;

    class DefiningClasesPart2
    {
        static void Main()
        {
            /* Task 1-4
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
            */

            /* Task 4-7
            GenericList<int> list = new GenericList<int>();
            list.AddAtEnd(9);
            list.AddAtEnd(8);
            list.AddAtEnd(10);
            list.AddAtEnd(11);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());

            list.RemoveFirst(9);

            Console.WriteLine(list.ToString());

            list[1] = 33;
            Console.WriteLine(list[1]);

            list.AddAt(1, 22);
            Console.WriteLine(list.ToString());

            Console.WriteLine(list.GetElementIndex(22));

            list.Clear();
            Console.WriteLine(list.ToString());
            */

            /* Task 8-10
            Matrix<int> firstMatrix = new Matrix<int>(3, 3, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix<int> secondMatrix = new Matrix<int>(3, 3, 9, 8, 7, 6, 5, 4, 3, 2, 1);

            Matrix<int> product = firstMatrix * secondMatrix;

            Console.WriteLine(product.ToString());
            */

            /* Task11
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<VersionAttribute>().Count() > 0
                        select t;

            foreach (var t in types)
            {
                Console.WriteLine(t.Name);

                foreach (var p in t.GetProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }
            */
        }
    }
}
