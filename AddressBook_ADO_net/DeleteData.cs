using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO_net
{
    public class DeleteData
    {
        public static void Deletedata(List<Contacts> list, string Fname,String Lname)
        {

            if(string.IsNullOrEmpty(Fname) && string.IsNullOrEmpty(Lname))
            {
                Console.WriteLine("please enter correct input");
            }
            else if(Fname.Length > 0 && Lname.Length>0)
            {
                Contacts ContactRem = null;
                foreach(Contacts contacts in list)
                {

                    if(contacts.FirstName==Fname && contacts.LastName==Lname)
                    {
                        ContactRem = contacts;
                    }
                }
                if(ContactRem != null)
                {
                    list.Remove(ContactRem);
                    Console.WriteLine("successful delete");
                }
                else
                {
                    Console.WriteLine("not found");
                }
            }
            Contacts.DeleteD(Fname, Lname);
            
        }
    }
}
