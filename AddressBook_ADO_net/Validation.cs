using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Address_Books
{
    public class Validation
    {
        private string Patname { get; set; } = @"^[A-Z][a-z]{2,9}$";
        private string Address { get; set; } = @"^[A-Za-z0-9\s.,#-]+$";
        private string Number { get; set; } = @"^[0-9]{10}$";
        private string Zip { get; set; } = @"^[0-9]{6}$";
        private string Email { get; set; } = @"^\w{3,}([.+-]\w{1,})?@\w{1,}\.[a-z]{2,}(.[a-z]{2,})?$";

        public bool IsName(string name)
        {
            return Regex.IsMatch(name, Patname);
        }

        public bool IsAddress(string address)
        {
            return Regex.IsMatch(address, Address);
        }

        public bool IsNumber(string number)
        {
            return Regex.IsMatch(number, Number);
        }

        public bool IsZip(string zip)
        {
            return Regex.IsMatch(zip, Zip);
        }

        public bool IsEmail(string email)
        {
            return Regex.IsMatch(email, Email);
        }

        public bool IsState(string state)
        {
            return Regex.IsMatch(state, Patname);
        }

        public bool IsCity(string city)
        {
            return Regex.IsMatch(city, Patname);
        }
    }
}