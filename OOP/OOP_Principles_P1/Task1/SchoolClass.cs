namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass
    {
        public SchoolClass()
        {
            this.Students = null;
            this.Teachers = null;
            this.TextIdentifier = string.Empty;
        }

        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string TextIdentifier { get; set; }
    }
}
