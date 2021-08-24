using BoardGameDay.Common.Entities;

namespace BoardGameDay.Domain.ValueObjects.EmailObj
{
    public class Email : Entity
    {
        public Email(string address)
        {
            Address = address;
            Validate(new EmailValidator(this));
        }

        public string Address { get; private set; }
    }
}
