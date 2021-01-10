using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exceptions;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public abstract class Phone : ICallable
    {
        public virtual string Call(string phoneNumber)
        {
            // Ако всички символи не са цифри, хвърли грешка
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }

            return phoneNumber;
        }
    }
}
