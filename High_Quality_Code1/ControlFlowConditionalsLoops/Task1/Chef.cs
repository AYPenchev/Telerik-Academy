namespace Task1
{
    using System.Collections.Generic;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            List<Vegetable> veggies = new List<Vegetable>()
            {
                potato,
                carrot
            };

            Bowl bowl;
            bowl = this.GetBowl(veggies);

            potato.Peel();
            carrot.Peel();

            potato.Cut();
            carrot.Cut();

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl(List<Vegetable> veggies)
        {
            return new Bowl(veggies);
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
