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
                Console.WriteLine("1: For the Family.");
                Console.WriteLine("2: For the Friends.");
                Console.WriteLine("3: For the Office.");

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
                            Console.WriteLine("0:To Exit");
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
                                        family.EditFamily();
                                        break;
                                    case "3":
                                        family.Delete();
                                        break;
                                    case "4":
                                        family.FamilyView();
                                        break;
                                    default:
                                        Console.WriteLine("Please enter correct option");
                                        break;
                                }
                                if (flag == 1)
                                    break;
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
                            Console.WriteLine("0:To Exit");
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
                                            friend.EditFriends();
                                            break;
                                        case "3":
                                            friend.Delete();
                                            break;
                                        case "4":
                                            friend.FriendsView();
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
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To Edit Office Contacts");
                            Console.WriteLine("3:To Remove a Office contact");
                            Console.WriteLine("4:To View Office contact");
                            Console.WriteLine("0:To Exit");
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
                                            office.EditOffice();
                                            break;
                                        case "3":
                                            office.Delete();
                                            break;
                                        case "4":
                                            office.OfficeView();
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


                }

            }

        }
    }
}