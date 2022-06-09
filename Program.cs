using System;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WelCome To The Address Book");
                Console.WriteLine("Select The Option For The Particular Address Book");
                Console.WriteLine("1 for the Friends.");
                Console.WriteLine("2 for the Office.");
                Console.WriteLine("3 for the Family.");

                int option = Convert.ToInt32(Console.ReadLine());
                int Select = 0;
                Program details = new Program();
                switch (option)
                {
                    case 1:
                        Friends friend = new Friends();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To View Office contact");
                            Console.WriteLine("3:To Edit Office Contacts");
                            Console.WriteLine("4:To Remove a Office contact");
                            Console.WriteLine("5: To search with city name");
                            Console.WriteLine("0:To Exit");

                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 0:
                                    Select = 1;
                                    break;
                                case 1:
                                    friend.AddingContacts();
                                    continue;
                                case 2:
                                    friend.DisplayContacts();
                                    continue;
                                case 3:
                                    friend.EditContact();
                                    continue;
                                case 4:
                                    friend.DeleteContact();
                                    continue;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string city = Console.ReadLine();
                                    friend.SearchPerson(city);
                                    continue;
                                default:
                                    Console.WriteLine("Enter a valid Input");
                                    break;
                            }
                            if (Select == 1) ;
                            break;
                        }
                        while (option != 0);
                        break;
                    case 2:
                        Office office = new Office();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To View Office contact");
                            Console.WriteLine("3:To Edit Office Contacts");
                            Console.WriteLine("4:To Remove a Office contact");
                            Console.WriteLine("5: To search with city name");
                            Console.WriteLine("0:To Exit");

                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 0:
                                    Select = 1;
                                    break;
                                case 1:
                                    office.AddingContacts();
                                    continue;
                                case 2:
                                    office.DisplayContacts();
                                    continue;
                                case 3:
                                    office.EditContact();
                                    continue;
                                case 4:
                                    office.DeleteContact();
                                    continue;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string City = Console.ReadLine();
                                    office.SearchPerson(City);
                                    continue;
                                default:
                                    Console.WriteLine("Enter a valid Input");
                                    break;
                            }
                            if (Select == 1) ;
                            break;
                        }
                        while (option != 0);
                        break;
                    case 3:
                        Family family  = new Family();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To View Office contact");
                            Console.WriteLine("3:To Edit Office Contacts");
                            Console.WriteLine("4:To Remove a Office contact");
                            Console.WriteLine("5: To search with city name");
                            Console.WriteLine("0:To Exit");

                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 0:
                                    Select = 1;
                                    break;
                                case 1:
                                    family.AddingContacts();
                                    continue;
                                case 2:
                                    family.DisplayContacts();
                                    continue;
                                case 3:
                                    family.EditContact();
                                    continue;
                                case 4:
                                    family.DeleteContact();
                                    continue;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string City = Console.ReadLine();
                                    family.SearchPerson(City);
                                    continue;
                                default:
                                    Console.WriteLine("Enter a valid Input");
                                    break;
                            }
                            if (Select == 1) ;
                            break;
                        }
                        while (option != 0);
                        break;
                }
            }
        }
    }
}