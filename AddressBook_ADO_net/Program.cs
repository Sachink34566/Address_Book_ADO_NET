using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO_net
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Contacts> list = new List<Contacts>();
            try
            {
                Console.WriteLine("Welcome to Address Book !\n");

                while (true)
                {
                    Console.WriteLine("\nEnter 1 -> adding person's contact.");
                    Console.WriteLine("Enter 2 -> edit contact via name.");
                    Console.WriteLine("Enter 3 -> delete contact.");
                    Console.WriteLine("Enter 4 -> display contacts.");
                    Console.WriteLine("Enter 5 -> exiting the addressbook.\n");

                    Console.WriteLine("enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("add details");
                            AddDetails.AddDetails1(list);
                            break;
                        case 2:
                            Console.WriteLine("Update data");
                            Console.WriteLine("enter first name");
                            string Fname1 = Console.ReadLine();

                            Console.WriteLine("enter Last Name");

                            string Lname1 = Console.ReadLine();

                            

                            UpdateData.Updatedata(list,Fname1,Lname1);
                            break;
                        case 3:
                            Console.WriteLine("Delete data");
                            Console.WriteLine("enter your First Name");
                            string Fname2 = Console.ReadLine();
                            Console.WriteLine("enter Last Name");
                            string Lname2 = Console.ReadLine();

                            DeleteData.Deletedata(list,Fname2,Lname2);
                            break;
                        case 4:
                            Console.WriteLine("display data");

                            Console.WriteLine("enter first name");
                            string Fname= Console.ReadLine();

                            Console.WriteLine("enter Last Name");

                            string Lname= Console.ReadLine();

                            if(string.IsNullOrEmpty(Fname) && string.IsNullOrEmpty(Lname))
                            {
                                Console.WriteLine("data are not found");
                            }
                            else
                            {
                                foreach (Contacts contact in list)
                                {
                                    contact.Display();
                                    Contacts.GetData(Fname, Lname);
                                }
                                
                            }
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("enter 1 to 4 range");
                            break;


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
