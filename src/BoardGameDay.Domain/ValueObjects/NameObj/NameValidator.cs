using BoardGameDay.Common.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGameDay.Domain.ValueObjects.NameObj
{
    public class NameValidator : Validation
    {
        public NameValidator(Name name)
        {
            IsNullOrEmpty(name.FirstName, "FirstName", "Nome não informado");
            IsNullOrEmpty(name.LastName, "LastName", "Sobrenome não informado");
        }
    }
}
