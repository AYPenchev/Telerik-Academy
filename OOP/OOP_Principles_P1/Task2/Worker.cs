namespace Task2
{
    using System;

    public class Worker : Human
    {
        public float workHoursPerDay;
        public int workDaysInWeek;

        public Worker() : base()
        {
            this.WeekSalary = 150;
            this.WorkHoursPerDay = 8;
            this.WorkDaysInWeek = 5;
        }

        public Worker(string firstName, string lastName, double weekSalary, float workHoursPerDay = 8, int workDaysInWeek = 5) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysInWeek = workDaysInWeek;
        }

        public double WeekSalary { get; set; }
        public float WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 1 || value > 16)
                {
                    throw new ArgumentOutOfRangeException("Something went wrong!");
                }

                this.workHoursPerDay = value;
            }
        }
        public int WorkDaysInWeek
        {
            get
            {
                return this.workDaysInWeek;
            }
            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("There are 7 days in a week!");
                }

                this.workDaysInWeek = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyEarnedPerHour = this.WeekSalary / (this.WorkDaysInWeek * this.WorkHoursPerDay);
            return moneyEarnedPerHour;
        }

        public override string ToString()
        {
            string stringify = "First name: " + this.FirstName + "\nLast name: " + this.LastName + "\nWeek salary: " + this.WeekSalary +
                            "\nWork hours per days: " + this.WorkHoursPerDay + "\nWork days in week: " + this.WorkDaysInWeek +
                            "\nMoney per hour: " + string.Format("{0:F2}\n", this.MoneyPerHour());
 
            return stringify;
        }
    }
}
