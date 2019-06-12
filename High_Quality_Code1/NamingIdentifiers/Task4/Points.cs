namespace Task4
{
    public class Points
    {
        public Points() { }

        public Points(string name, int points)
        {
            this.Name = name;
            this.PointsIn = points;
        }

        public string Name { get; set; }

        public int PointsIn { get; set; }
    }
}
