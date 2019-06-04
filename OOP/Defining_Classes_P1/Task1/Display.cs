namespace Task1
{
    class Display
    {
        public Display()
        {
            this.InchSize = null;
            this.NumberColors = null;
        }

        public Display(double? inchSize = null, int? numberColors = null)
        {
            this.InchSize = inchSize;
            this.NumberColors = numberColors;
        }

        public double? InchSize { get; private set; }
        public int? NumberColors { get; private set; }

        public override string ToString()
        {
            return string.Format("\n    1.Inch size:  {0} \n    2.Number of colors:  {1} \n"
                                , this.InchSize, this.NumberColors);
        }
    }
}
