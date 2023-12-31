﻿namespace minimalAPI.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public virtual Employee? Employee { get; set; }

        public virtual Student? Student { get; set; }
    }
}
