using System;
using System.Collections.Generic;

namespace AddressBook_ADO_net
{
    public class UpdateData
    {
        public static void Updatedata(List<Contacts> list, string originalFirstName, string originalLastName)
        {
            try
            {
                if (string.IsNullOrEmpty(originalFirstName) || string.IsNullOrEmpty(originalLastName))
                {
                    Console.WriteLine("Enter correct input");
                    return;
                }

                bool contactFound = false;

                foreach (Contacts contact in list)
                {
                    if (contact.FirstName == originalFirstName && contact.LastName == originalLastName)
                    {
                        contactFound = true;

                        while (true)
                        {
                            Console.WriteLine("\nEnter 1 -> edit First Name");
                            Console.WriteLine("Enter 2 -> edit Last Name");
                            Console.WriteLine("Enter 3 -> edit Email");
                            Console.WriteLine("Enter 4 -> edit Phone Number");
                            Console.WriteLine("Enter 5 -> edit Address");
                            Console.WriteLine("Enter 6 -> edit City");
                            Console.WriteLine("Enter 7 -> edit State");
                            Console.WriteLine("Enter 8 -> edit Zip Code");
                            Console.WriteLine("Enter 9 -> exit editing\n");

                            Console.WriteLine("Enter your choice");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter First Name");
                                    contact.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Last Name");
                                    contact.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Email");
                                    contact.Email = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter Phone Number");
                                    contact.PhoneNumber = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter Address");
                                    contact.Address = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter City");
                                    contact.City = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter State");
                                    contact.State = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter Zip Code");
                                    contact.ZipCode = Console.ReadLine();
                                    break;
                                case 9:
                                    Contacts.UpdateD(originalFirstName, originalLastName, contact);
                                    return;
                                default:
                                    Console.WriteLine("Enter valid input");
                                    break;
                            }
                        }
                    }
                }

                if (!contactFound)
                {
                    Console.WriteLine("Contact not found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

