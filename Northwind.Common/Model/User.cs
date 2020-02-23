using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Northwind.Common.Model
{
    public class User
    {
        public User()
        {
            // Hack
            //ID = UserName.GetHashCode();
        }
        public int ID { get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Hashcode
        public int Password { get; set; }
        public int PasswordCheck { get; set; }

        public bool Validate()
        {
            bool isValid = false;
            bool ispasswordValid = 
                Password == PasswordCheck ? true : false;
            bool isEmail = Regex.IsMatch(
                Email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);

            if (isEmail && ispasswordValid)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
