namespace Task1
{
    using System;

    class Display
    {
        public Display()
        {
            this.InchSize = null;
            this.NumberColors = null;
        }

        public double? InchSize { get; private set; }
        public int? NumberColors { get; private set; }
    }
}
