using BoardGameDay.Common.Validations;

namespace BoardGameDay.Domain.ValueObjects.EmailObj
{
    public class EmailValidator : Validation
    {
        public EmailValidator(Email email)
        {
            IsNullOrEmpty(email.Address, "Email", "E-mail não informado");
            IsInvalidEmail(email.Address, "Email", "E-mail inválido");
        }
    }
}
