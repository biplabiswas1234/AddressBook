using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class Family
    {
        ArrayList contact = new ArrayList();
        List<Contacts> lists = new List<Contacts>();
        public void AddingContacts()
        {
            Console.WriteLine("Enter number of Contacts:");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("Add Details of the person: " + i);
                Console.WriteLine("Enter the First Name:");
                string FirstName = Console.ReadLine();

                Console.WriteLine("Enter the Last Name:");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter the Address:");
                string Address = Console.ReadLine();

                Console.WriteLine("Enter the City:");
                string City = Console.ReadLine();

                Console.WriteLine("Enter the State:");
                string State = Console.ReadLine();

                Console.WriteLine("Enter the Email:");
                string Email = Console.ReadLine();

                Console.WriteLine("Enter the Zipcode:");
                int Zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the phone number:");
                long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Contacts contacts = new Contacts(FirstName, LastName, Address, City, State, Email, Zip, PhoneNumber);
                lists.Add(contacts);
                contact.Add(FirstName);
                contact.Add(LastName);
                contact.Add(Address);
                contact.Add(City);
                contact.Add(State);
                contact.Add(Email);
                contact.Add(Zip);
                contact.Add(PhoneNumber);
            }
        }
        public void DisplayContacts()
        {
            int j = 0;
            int count = 1;
            foreach (var item in contact)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("\nNumber of person :" + count);
                    Console.WriteLine("FirstName: " + contact[j]);
                    Console.WriteLine("LastName: " + contact[j + 1]);
                    Console.WriteLine("Address : " + contact[j + 2]);
                    Console.WriteLine("City: " + contact[j + 3]);
                    Console.WriteLine("State: " + contact[j + 4]);
                    Console.WriteLine("Email: " + contact[j + 5]);
                    Console.WriteLine("ZipCode: " + contact[j + 6]);
                    Console.WriteLine("Phone Number: " + contact[j + 7]);
                    count++;
                }
                j++;
            }
        }
        public void EditContact()
        {
            Console.WriteLine("\nEnter the Name whose data you want to change");
            string Firstname = Console.ReadLine();
            for (int i = 0; i < contact.Count; i += 8)
            {
                if (String.Equals(Firstname, (contact[i])))
                {
                    Console.WriteLine("Name:" + contact + "==" + contact[i]);
                    Console.WriteLine("Press 1: for first name");
                    Console.WriteLine("Press 2: for last name name");
                    Console.WriteLine("Press 3: for Address");
                    Console.WriteLine("Press 4: for city name");
                    Console.WriteLine("Press 5: for state name");
                    Console.WriteLine("Press 6: for Email ID");
                    Console.WriteLine("Press 7: for ZIP number");
                    Console.WriteLine("Press 8: for phone number");

                    int check = Convert.ToInt32(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            Console.WriteLine("Enter your correct first name");
                            string FirstName = Console.ReadLine();
                            contact[i] = FirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter your correct last name");
                            string LastName = Console.ReadLine();
                            contact[i + 1] = LastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter your correct Address");
                            string Address = Console.ReadLine();
                            contact[i + 2] = Address;
                            break;
                        case 4:
                            Console.WriteLine("Enter your correct city name");
                            string City = Console.ReadLine();
                            contact[i + 3] = City;
                            break;
                        case 5:
                            Console.WriteLine("Enter your correct state name");
                            string State = Console.ReadLine();
                            contact[i + 4] = State;
                            break;
                        case 6:
                            Console.WriteLine("Enter your correct EmailID");
                            string Email = Console.ReadLine();
                            contact[i + 5] = Email;
                            break;
                        case 7:
                            Console.WriteLine("Enter your correct ZIP number");
                            int Zip = Convert.ToInt32(Console.ReadLine());
                            contact[i + 6] = Zip;
                            break;
                        case 8:
                            Console.WriteLine("Enter your correct Phone number");
                            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            contact[i + 7] = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the name you want to remove");
            string Firstname = Console.ReadLine();
            for (int i = 0; i < contact.Count; i += 8)
            {
                if (string.Equals(Firstname, (contact[i])))
                {
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                    contact.RemoveAt(i);
                }
            }
        }
        public void SearchPerson(string City)
        {
            var result = lists.FindAll(r => r.City == City);
            Console.WriteLine("Details of people who live in city: ");
            foreach (var item in result)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                    "\nAddress :" + item.Address + " " + "\nCity :" + item.City + " " +
                                    "\nState :" + item.State + " " + "\nEmail :" + item.Email + " " +
                                    "\nZip Code :" + item.Zip + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    }
}
