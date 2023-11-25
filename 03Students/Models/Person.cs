// Models.Person.cs

namespace DSS.Models
{
    public class Person
    {
        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public Gender Gender { get; set; } = Gender.Male;
        public PostalAddress Address { get; set; } = new PostalAddress();
    }
}
