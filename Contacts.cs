using System;
using System.Collections.Generic;
using System.Text;

namespace AddressAD
{
    internal class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public Contacts(string FirstName, string LastName, string City, string State, string Email, string Zip, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
            this.State = State;
            this.Email = Email;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
        }
        public override string ToString()
        {
            return "First Name : " + FirstName + "\nLast Name " + LastName + "\nAddress : " + "\nCity :" + City + "\nState :" + State + "\nEmailId :" + Email + "\nZip Code :" + Zip + "\nPhone Number :" + PhoneNumber;
        }
    }
}
