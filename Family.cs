using AddressAD;
using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBook
{
    internal class Family
    {

        ArrayList personlist = new ArrayList();
        List<Contacts> ContactLists = new List<Contacts>();

        public void Addition()
        {
            Console.WriteLine("Enter number of person contact address to save");
            //int Num = Convert.ToInt32(Console.ReadLine());
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
                Contacts contacts = new Contacts(First_Name, Last_Name, City, State, EmailID, ZIP, PhoneNum);
                ContactLists.Add(contacts);

            }

        }




        public void FamilyView()
        {
            int j = 0;
            int count = 1;
            if (personlist.Count > 0)
            {

                foreach (var item in personlist)
                {
                    if (j % 7 == 0)
                    {
                        Console.WriteLine("\n");
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
            else
            {
                Console.WriteLine("Your Book is Empty");
            }
        }
        public void Allperson()
        {
            int count = 1;
            foreach (Contacts person in ContactLists)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAddress of person number: " + count);
                Console.WriteLine("First name: " + person.FirstName);
                Console.WriteLine("Last name: " + person.LastName);
                Console.WriteLine("Email id: " + person.Email);
                Console.WriteLine("City name: " + person.City);
                Console.WriteLine("State name: " + person.State);
                Console.WriteLine("ZIP name: " + person.Zip);
                Console.WriteLine("Phone number: " + person.PhoneNumber);
                count++;

            }
        }
        //public void EditFamily()
        //{

        //    if (personlist.Count > 0)
        //    {
        //        Console.WriteLine("\nEnter the Name whose data you want to change");
        //        Console.WriteLine("Enter first name");
        //        string FirstNamee = Console.ReadLine();
        //        Console.WriteLine("Enter Last name");
        //        string LastNamee = Console.ReadLine();
        //        for (int i = 0; i < personlist.Count; i += 7)
        //        {
        //            if (String.Equals(FirstNamee, (personlist[i])) && string.Equals(LastNamee, (personlist[i + 1])))
        //            {
        //                Console.WriteLine("Press 1: for first name");
        //                Console.WriteLine("Press 2: for last name name");
        //                Console.WriteLine("Press 3: for city name");
        //                Console.WriteLine("Press 4: for state name");
        //                Console.WriteLine("Press 5: for ZIP number");
        //                Console.WriteLine("Press 6: for phone number");
        //                Console.WriteLine("Press 7: for Email ID");
        //                String check = Console.ReadLine();
        //                switch (check)
        //                {
        //                    case "1":
        //                        Console.WriteLine("Enter your correct first name");
        //                        string FirstName = Console.ReadLine();
        //                        personlist[i] = FirstName;
        //                        break;
        //                    case "2":
        //                        Console.WriteLine("Enter your correct last name");
        //                        string LastName = Console.ReadLine();
        //                        personlist[i + 1] = LastName;
        //                        break;
        //                    case "3":
        //                        Console.WriteLine("Enter your correct city name");
        //                        string City = Console.ReadLine();
        //                        personlist[i + 2] = City;
        //                        break;
        //                    case "4":
        //                        Console.WriteLine("Enter your correct state name");
        //                        string State = Console.ReadLine();
        //                        personlist[i + 3] = State;
        //                        break;
        //                    case "5":
        //                        Console.WriteLine("Enter your correct ZIP number");
        //                        string ZIP = Console.ReadLine();
        //                        personlist[i + 4] = ZIP;
        //                        break;
        //                    case "6":
        //                        Console.WriteLine("Enter your correct Phone number");
        //                        string PhoneNum = Console.ReadLine();
        //                        personlist[i + 5] = PhoneNum;
        //                        break;
        //                    case "7":
        //                        Console.WriteLine("Enter your correct EmailID");
        //                        string EmailID = Console.ReadLine();
        //                        personlist[i + 6] = EmailID;
        //                        break;
        //                    default:
        //                        Console.WriteLine("Please enter a valid input");
        //                        break;

        //                }
        //            }
        //        }
        //    }

        //    else
        //    {
        //        Console.WriteLine("Sorry Your Book is Empty");
        //    }

        //}
        public void Edit()
        {
            Console.WriteLine("Enter first name");
            string First_Name = Console.ReadLine();
            foreach (Contacts person in ContactLists)
            {
                if (person.FirstName == First_Name)
                {
                    Console.WriteLine("Press 1: for first name");
                    Console.WriteLine("Press 2: for last name name");
                    Console.WriteLine("Press 3: for city name");
                    Console.WriteLine("Press 4: for state name");
                    Console.WriteLine("Press 5: for ZIP number");
                    Console.WriteLine("Press 6: for phone number");
                    Console.WriteLine("Press 7: for Email ID");
                    String check = Console.ReadLine();
                    switch (check)
                    {
                        case "1":
                            Console.WriteLine("Enter your correct first name");
                            string FirstName = Console.ReadLine();
                            person.FirstName = FirstName;
                            break;
                        case "2":
                            Console.WriteLine("Enter your correct last name");
                            string LastName = Console.ReadLine();
                            person.LastName = LastName;
                            break;
                        case "3":
                            Console.WriteLine("Enter your correct city name");
                            string City = Console.ReadLine();
                            person.City = City;
                            break;
                        case "4":
                            Console.WriteLine("Enter your correct state name");
                            string State = Console.ReadLine();
                            person.State = State;
                            break;
                        case "5":
                            Console.WriteLine("Enter your correct ZIP number");
                            string ZIP = Console.ReadLine();
                            person.Zip = ZIP;
                            break;
                        case "6":
                            Console.WriteLine("Enter your correct Phone number");
                            string PhoneNum = Console.ReadLine();
                            person.PhoneNumber = PhoneNum;
                            break;
                        case "7":
                            Console.WriteLine("Enter your correct EmailID");
                            string EmailID = Console.ReadLine();
                            person.Email = EmailID;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;


                    }
                }
            }
        }
        //public void Delete()
        //{
        //    Console.WriteLine("Enter First name");
        //    string FirstNamee = Console.ReadLine();
        //    Console.WriteLine("Enter Last name");
        //    string LastNamee = Console.ReadLine();
        //    for (int i = 0; i < personlist.Count; i += 7)
        //    {
        //        if (String.Equals(FirstNamee, (personlist[i])) && string.Equals(LastNamee, (personlist[i + 1])))

        //        {

        //            personlist.RemoveAt(i);
        //            personlist.RemoveAt(i);
        //            personlist.RemoveAt(i);
        //            personlist.RemoveAt(i);
        //            personlist.RemoveAt(i);
        //            personlist.RemoveAt(i);
        //            personlist.RemoveAt(i);
        //        }

        //    }
        //}
        //public void SearchCity()
        //{
        //    Console.WriteLine("Enter city name");
        //    string cityName = Console.ReadLine();
        //    int count = 0;
        //    for (int i = 2; i < personlist.Count; i += 7)
        //    {
        //        if (String.Equals(cityName, (personlist[i])))

        //        {
        //            count++;
        //            Console.WriteLine("\n");
        //            Console.WriteLine("\nPerson number:" + count);
        //            Console.WriteLine("First Name: " + personlist[i - 2]);
        //            Console.WriteLine("Last Name: " + personlist[i - 1]);
        //            Console.WriteLine("City Name: " + personlist[i]);
        //            Console.WriteLine("State Name: " + personlist[i + 1]);
        //            Console.WriteLine("ZIP Number:" + personlist[i + 2]);
        //            Console.WriteLine("Phone Number:" + personlist[i + 3]);
        //            Console.Write("Email ID:" + personlist[i + 4]);

        //        }


        //    }
        //    if (count == 0)
        //    {
        //        Console.WriteLine("Not available");
        //    }
        //}

        public void SearchPerson()
        {
            Console.WriteLine("Enter city");
            string City = Console.ReadLine();
            var result = ContactLists.FindAll(r => r.City == City);
            Console.WriteLine("Details of people who live in city: ");
            foreach (var item in result)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                     " " + "\nCity :" + item.City + " " +
                                    "\nState :" + item.State + " " + "\nEmail :" + item.Email + " " +
                                    "\nZip Code :" + item.Zip + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
        public void ViewByState()
        {
            Console.WriteLine("Enter state name");
            string State = Console.ReadLine();
            var result = ContactLists.FindAll(r => r.State == State);
            Console.WriteLine("Details of people who live in state :");
            foreach (var item in result)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                  "\nEmail ID :" + item.Email + " " +
                                  "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                  "\nZip Code :" + item.Zip + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
        public int Countperson()
        {
            Console.WriteLine("Count Person-City and state wise:");
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter state");
            string State = Console.ReadLine();
            var result = ContactLists.FindAll(r => (r.City == City && r.State == State));
            foreach (var item in result)
            {

                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                   "\nEmail ID :" + item.Email + " " + "\nAddress :" +
                                   "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                   "\nZip Code :" + item.Zip + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            var results = result.Count;
            Console.WriteLine($"Total Persons in City: {City} & State: {State}: are " + results);
            return results;
        }
        public void SortByPersonName()
        {
            var Sort = ContactLists.OrderBy(r => r.FirstName).ToList();
            foreach (var item in Sort)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                 "\nEmail ID :" + item.Email + " " +
                                 "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                 "\nZip Code :" + item.Zip + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
        public void SortByCityName()
        {
            var Sort = ContactLists.OrderBy(r => r.City).ToList();
            foreach (var item in Sort)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                 "\nEmail ID :" + item.Email + " " +
                                 "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                 "\nZip Code :" + item.Zip + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }

        public void Remove()
        {
            Console.WriteLine("Enter first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string LastName = Console.ReadLine();
            var result = ContactLists.RemoveAll(r => (r.FirstName == FirstName && r.LastName == LastName));
            int count = 1;
            foreach (Contacts person in ContactLists)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAddress of person number: " + count);
                Console.WriteLine("First name: " + person.FirstName);
                Console.WriteLine("Last name: " + person.LastName);
                Console.WriteLine("Email id: " + person.Email);
                Console.WriteLine("City name: " + person.City);
                Console.WriteLine("State name: " + person.State);
                Console.WriteLine("ZIP name: " + person.Zip);
                Console.WriteLine("Phone number: " + person.PhoneNumber);
                count++;

            }
        }
        public void ContactDetailsInFile()
        {
            string Write = @"C:\Users\bipbi\OneDrive\Desktop\Bridgelabz\PracticeRFP\AddressAD\PersonName.txt";
            using (StreamWriter streamWriter = File.AppendText(Write))
            {
                foreach (var item in ContactLists)
                {
                    streamWriter.WriteLine(item);
                }
                streamWriter.Close();
            }
            Console.WriteLine("\n");
            string InputFile = @"C:\Users\bipbi\OneDrive\Desktop\Bridgelabz\PracticeRFP\AddressAD\PersonName.txt";
            string file = File.ReadAllText(InputFile);
            Console.WriteLine(file);
        }
        public void WriteAndReadCSVFile()
        {
            string FilePath = @"C:\Users\bipbi\OneDrive\Desktop\Bridgelabz\PracticeRFP\AddressAD\FamilyContactDetails.csv";
            using (var writer = new StreamWriter(FilePath))
            using (CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteHeader<Contacts>();
                foreach (var contact in ContactLists)
                {
                    csvWriter.NextRecord();
                    csvWriter.WriteRecord(contact);
                }
            }
            using (TextReader reader = new StreamReader(FilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contacts>().ToList();
                foreach (Contacts contacts in records)
                {
                    Console.WriteLine(contacts);
                }
            }

        }
        public void WriteJsonFile()
        {
            string JsonPath = @"C:\Users\bipbi\OneDrive\Desktop\Bridgelabz\PracticeRFP\AddressAD\FamilyContact.json";
            string jsonData = JsonConvert.SerializeObject(ContactLists);
            using (StreamWriter writer = new StreamWriter(JsonPath))
            {
                writer.Flush();
                writer.Write(jsonData);
                Console.WriteLine(jsonData);
            }
        }
        public void ReadJsonFile()
        {
            string JsonPath = @"C:\Users\bipbi\OneDrive\Desktop\Bridgelabz\PracticeRFP\AddressAD\FamilyContact.json";
            string result = File.ReadAllText(JsonPath);
            var deserialise = JsonConvert.DeserializeObject<List<Contacts>>(result);
            foreach (var contact in deserialise)
            {
                Console.WriteLine(contact);
            }
        }
        public void WriteAndReadJsonFile()
        {
            Console.WriteLine("Choose The option for Write and Read File");
            Console.WriteLine("1: For Write Json File");
            Console.WriteLine("2: For Read Json File");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    WriteJsonFile();
                    break;
                case 2:
                    ReadJsonFile();
                    break;
                default:
                    Console.WriteLine("Choose Correct option");
                    break;
            }
        }
    }
}

