using System;
using Telephony.Exceptions;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split(' ');
            string[] siteUrl = Console.ReadLine().Split(' ');

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartPhone = new Smartphone();

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                try
                {
                    if (phoneNumber[i].Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(phoneNumber[i]));
                    }
                    else if (phoneNumber[i].Length == 10)
                    {
                        Console.WriteLine(smartPhone.Call(phoneNumber[i]));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }


            for (int i = 0; i < siteUrl.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartPhone.Browse(siteUrl[i]));
                }
                catch (InvalidUrlException ex)
                {
                    Console.WriteLine(ex.Message);
                } 
            }
        }
    }
}
