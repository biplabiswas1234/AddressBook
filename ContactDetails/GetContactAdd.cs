using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ContactDetails
{
    internal class ContactAddress
    {
        ArrayList personlist = new ArrayList();

        public void Addition()
        {
            Console.WriteLine("Enter number of person contact address to save");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("\nAdd details of person number: " + i);

                Console.WriteLine("Enter your First name");
                string First_Name = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                string Last_Name = Console.ReadLine();
                Console.WriteLine("Enter your city name");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your state name");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your ZIP number");
                string ZIP = Console.ReadLine();
                Console.WriteLine("Enter your phone number");
                string PhoneNum = Console.ReadLine();
                Console.WriteLine("Enter your Email ID");
                string EmailID = Console.ReadLine();
                personlist.Add(First_Name);
                personlist.Add(Last_Name);
                personlist.Add(City);
                personlist.Add(State);
                personlist.Add(ZIP);
                personlist.Add(PhoneNum);
                personlist.Add(EmailID);
            }
            int j = 0;
            int count = 1;
            foreach (var item in personlist)
            {
                if (j % 7 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + personlist[j]);
                    Console.WriteLine("Last Name: " + personlist[j+1]);
                    Console.WriteLine("City Name: " + personlist[j+2]);
                    Console.WriteLine("State Name: " + personlist[j+3]);
                    Console.WriteLine("ZIP Number:" + personlist[j+4]);
                    Console.WriteLine("Phone Number:" + personlist[j+5]);
                    Console.Write("Email ID:" + personlist[j+6]);
                    count++;

                }
                j++;
            }
            
        }

        public void ViewWage()
        {
            Console.WriteLine("\nEnter the first name whose data you want to delete");
            string Name=Console.ReadLine();
            for (int i = 0; i < personlist.Count; i += 7)
            {
                if (String.Equals(Name, (personlist[i])))
                {
                
                    personlist.RemoveAt(i);
                    personlist.RemoveAt(i);
                    personlist.RemoveAt(i);
                    personlist.RemoveAt(i);
                    personlist.RemoveAt(i);
                    personlist.RemoveAt(i);
                    personlist.RemoveAt(i);
                }
                
            }
                   int j = 0;
                   int count = 1;
                   foreach (var item in personlist)
                   {
                    if (j % 7 == 0)
                    {
                    Console.WriteLine("\nAfter editing the datas are:");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + personlist[j]);
                    Console.WriteLine("Last Name: " + personlist[j + 1]);
                    Console.WriteLine("City Name: " + personlist[j + 2]);
                    Console.WriteLine("State Name: " + personlist[j + 3]);
                    Console.WriteLine("ZIP Number:" + personlist[j + 4]);
                    Console.WriteLine("Phone Number:" + personlist[j + 5]);
                    Console.Write("Email ID:" + personlist[j + 6]);
                    count++;

                    }
                    j++;
                   }

        }

    }
}