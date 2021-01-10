using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exceptions;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : Phone
    {
        public sealed override string Call(string phoneNumber)
        {
            return $"Dialing... {base.Call(phoneNumber)}";
        }
    }
}
