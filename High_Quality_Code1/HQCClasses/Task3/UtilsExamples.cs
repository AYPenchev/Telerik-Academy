namespace Task3
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(UtilsExtensions.GetFileExtension("example"));
            Console.WriteLine(UtilsExtensions.GetFileExtension("example.pdf"));
            Console.WriteLine(UtilsExtensions.GetFileExtension("example.new.pdf"));

            Console.WriteLine(UtilsExtensions.GetFileNameWithoutExtension("example"));
            Console.WriteLine(UtilsExtensions.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(UtilsExtensions.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Utils2D.CalcDistance2D(1, -2, 3, 4));

            Console.WriteLine("Distance in the 3D space = {0:f2}", Utils3D.CalcDistance3D(5, 2, -1, 3, -6, 4));
            Console.WriteLine("Volume = {0:f2}", Utils3D.CalcVolume(3, 4, 5));
        }
    }
}
