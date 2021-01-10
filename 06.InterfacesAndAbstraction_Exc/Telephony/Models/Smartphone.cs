using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exceptions;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : Phone, IBrowsable
    {
        public string Browse(string url)
        {
            // Ако някой символ е цифра, хвърли грешка
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidUrlException();
            }

            return $"Browsing: {url}!";
        }

        public sealed override string Call(string phoneNumber)
        {
            return $"Calling... {base.Call(phoneNumber)}";
        }
    }
}
