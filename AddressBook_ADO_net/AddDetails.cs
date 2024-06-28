using Address_Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Address_Books.CustomException;



namespace AddressBook_ADO_net
{
    public class AddDetails
    {
        public static void AddDetails1(List<Contacts> list)
        {
           
            try
            {
                Validation validation = new Validation();

                Console.WriteLine("Enter First Namr");
                string firstname = Console.ReadLine();
                if (!validation.IsName(firstname)) throw new InvalidNameException();

                Console.WriteLine("Enter Last Name");
                string lastname = Console.ReadLine();
                if (!validation.IsName(lastname)) throw new InvalidNameException();

                Console.WriteLine("Enter Phone number");
                string phonenumber = Console.ReadLine();
                if(!validation.IsNumber(phonenumber)) throw new InvalidNumberException();

                Console.WriteLine("enter Email");
                string email = Console.ReadLine();
                if (!validation.IsEmail(email)) throw new InvalidEmailException();

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                if (!validation.IsAddress(address)) throw new InvalidAddressException();

                Console.WriteLine("Enter City");
                string city = Console.ReadLine();
                if (!validation.IsCity(city)) throw new InvalidCityException();

                Console.WriteLine("Enter State");
                string state = Console.ReadLine();
                if(!validation.IsState(state)) throw new InvalidStateException();

                Console.WriteLine("enter zip");
                string zip = Console.ReadLine();
                if (!validation.IsZip(zip)) throw new InvalidZipException();

                Contacts contacts = new Contacts(firstname, lastname, phonenumber, email, address, city, state, zip);
                contacts.Insert();
                list.Add(contacts);
                foreach(Contacts item in list)
                {
                    item.Display();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
