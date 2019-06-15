namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;

            potato.Peel();
            carrot.Peel();

            bowl = GetBowl();

            potato.Cut();
            carrot.Cut();

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            return new Bowl(new List<Vegetable>());
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }
    }
}
