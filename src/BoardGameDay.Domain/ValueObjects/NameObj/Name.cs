using BoardGameDay.Common.Entities;

namespace BoardGameDay.Domain.ValueObjects.NameObj
{
    public class Name : Entity
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Validate(new NameValidator(this));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
