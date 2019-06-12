namespace Task2
{
    public class TestHuman
    {
        public static void MakeHuman(int age)
        {
            Human currentHuman = new Human();
            currentHuman.Age = age;
            if (age % 2 == 0)
            {
                currentHuman.Name = "Peter";
                currentHuman.Sex = Sex.Man;
            }
            else
            {
                currentHuman.Name = "Ani";
                currentHuman.Sex = Sex.Woman;
            }
        }

        public static void Main()
        {
            MakeHuman(2);
        }
    }
}
