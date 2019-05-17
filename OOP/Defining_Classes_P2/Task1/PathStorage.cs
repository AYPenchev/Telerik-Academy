namespace Task1
{
    using System;
    using System.IO;
    using System.Linq;

    class PathStorage
    {
        public static void SaveToFile(Path path)
        {
            File.WriteAllText("../../savedToFile.txt", path.ToString());
        }

        public static Path LoadFromFile()
        {
            Path loadPath = new Path();
            string content = File.ReadAllText("../../savedToFile.txt");
            string[] points = content.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < points.Length; i++)
            {
                double[] coords = points[i].Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                loadPath.Add(new Point3D(coords[0], coords[1], coords[2]));
            }
            return loadPath;
        }
    }
}
