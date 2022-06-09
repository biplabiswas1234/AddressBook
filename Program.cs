using System;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool i = true;
            while (i == true)
            {

                Console.WriteLine("WelCome To The Address Book");
                Console.WriteLine("Select The Option For The Particular Address Book");
                Console.WriteLine("1: For the Family.");
                Console.WriteLine("2: For the Friends.");
                Console.WriteLine("3: For the Office.");
                Console.WriteLine("0: For stop");

                int option = Convert.ToInt32(Console.ReadLine());
                Program details = new Program();
                int flag = 0;
                switch (option)
                {
                    case 1:
                        Family family = new Family();

                        do
                        {
                            Console.WriteLine("\n1:To Add a Family Contact");
                            Console.WriteLine("2:To Edit Family Contacts");
                            Console.WriteLine("3:To Remove a Family contact");
                            Console.WriteLine("4:To View Family contact");
                            Console.WriteLine("5: Search by city name");
                            Console.WriteLine("6: Search by state name");
                            Console.WriteLine("7: Count person");
                            Console.WriteLine("8: Sort by Person name");
                            Console.WriteLine("9: Sort by city name");
                            Console.WriteLine("0:Back");
                            {
                                string option1 = Console.ReadLine();

                                {
                                    switch (option1)
                                    {
                                        case "0":
                                            flag = 1;
                                            break;
                                        case "1":
                                            family.Addition();
                                            continue;
                                        case "2":
                                            family.Edit();
                                            break;
                                        case "3":
                                            family.Remove();
                                            break;
                                        case "4":
                                            family.Allperson();
                                            break;
                                        case "5":
                                            family.SearchPerson();
                                            break;
                                        case "6":
                                            family.ViewByState();
                                            break;
                                        case "7":
                                            family.Countperson();
                                            break;
                                        case "8":
                                            family.SortByPersonName();
                                            break;
                                        case "9":
                                            family.SortByCityName();
                                            break;
                                        
                                        default:
                                            Console.WriteLine("Please enter correct option");
                                            break;
                                    }
                                    if (flag == 1)
                                        break;
                                }
                            }
                        }
                        while (option != 0);
                        break;
                    case 2:

                        Friends friend = new Friends();

                        do
                        {
                            Console.WriteLine("\n1:To Add a Friends Contact");
                            Console.WriteLine("2:To Edit Friends Contacts");
                            Console.WriteLine("3:To Remove a Friends contact");
                            Console.WriteLine("4:To View Friends contact");
                            Console.WriteLine("5: Search by city name");
                            Console.WriteLine("6: Search by state name");
                            Console.WriteLine("7: Count person");
                            Console.WriteLine("8: Sort by Person name");
                            Console.WriteLine("9: Sort by city name");

                            Console.WriteLine("0:Back");
                            {
                                string option1 = Console.ReadLine();

                                {
                                    switch (option1)
                                    {
                                        case "0":
                                            flag = 1;
                                            break;
                                        case "1":
                                            friend.Addition();
                                            continue;
                                        case "2":
                                            friend.Edit();
                                            break;
                                        case "3":
                                            friend.Remove();
                                            break;
                                        case "4":
                                            friend.Allperson();
                                            break;
                                        case "5":
                                            friend.SearchPerson();
                                            break;
                                        case "6":
                                            friend.ViewByState();
                                            break;
                                        case "7":
                                            friend.Countperson();
                                            break;
                                        case "8":
                                            friend.SortByPersonName();
                                            break;
                                        case "9":
                                            friend.SortByCityName();
                                            break;
                                        default:
                                            Console.WriteLine("Please enter correct option");
                                            break;
                                    }
                                    if (flag == 1)
                                        break;
                                }
                            }

                        }

                        while (option != 0);
                        break;

                    case 3:

                        Office office = new Office();

                        do
                        {
                            Console.WriteLine("\n1: To Add a Office Contact");
                            Console.WriteLine("2: To Edit Office Contacts");
                            Console.WriteLine("3: To Remove a Office contact");
                            Console.WriteLine("4: To View Office contact");
                            Console.WriteLine("5: search by city name");
                            Console.WriteLine("6: Search by state name");
                            Console.WriteLine("7: Count person");
                            Console.WriteLine("8: Sort by Person name");
                            Console.WriteLine("0: Back");
                            {
                                string option1 = Console.ReadLine();

                                {
                                    switch (option1)
                                    {
                                        case "0":
                                            flag = 1;
                                            break;
                                        case "1":
                                            office.Addition();
                                            continue;
                                        case "2":
                                            office.Edit();
                                            break;
                                        case "3":
                                            office.Remove();
                                            break;
                                        case "4":
                                            office.Allperson();
                                            break;
                                        case "5":
                                            office.SearchPerson();
                                            break;
                                        case "6":
                                            office.ViewByState();
                                            break;
                                        case "7":
                                            office.Countperson();
                                            break;
                                        case "8":
                                            office.SortByPersonName();
                                            break;
                                        case "9":
                                            office.SortByCityName();
                                            break;
                                        default:
                                            Console.WriteLine("Please enter correct option");
                                            break;
                                    }
                                    if (flag == 1)
                                        break;
                                }
                            }
                        }
                        while (option != 0);
                        break;



                    case 0:
                        i = false;
                        break;

                }

            }

        }
    }
}