namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.SchoolClasses = null;
        }

        public List<SchoolClass> SchoolClasses { get; set; }
    }
}
