using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public Person() { 
            Name = null;
            Surname = null;
        }

    }
}