using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace AddressBook_ADO_net
{
    public class Contacts
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;

        public Contacts(string firstName, string lastName, string phoneNumber, string email, string address, string city, string state, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public void Display()
        {
            Console.WriteLine($"{FirstName}, {LastName}, {PhoneNumber}, {Email}, {Address}, {City}, {State}, {ZipCode}");
        }

        static string ConnectionString = @"Data Source=LAPTOP-QQBSMJER\SQLEXPRESS;Initial Catalog=ADONetDB;Integrated Security=SSPI";


        public void Insert()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "insert into Address__Books (Firstname, Lastname, Phonenumber, Email,Address, City, State,ZipCode) values (@Firstname, @Lastname,@Phonenumber,@Email, @Address,@City, @State,@ZipCode)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@State", State);
                    cmd.Parameters.AddWithValue("@ZipCode", ZipCode);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("insert successfull");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void GetData(String firstname,string lastname)
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "select * from Address__Books where FirstName=@FirstName and LastName=@LastName";
                SqlCommand cmd= new SqlCommand(query,conn);

                cmd.Parameters.AddWithValue("@FirstName",firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                
                
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"First Name: {reader["FirstName"]}\n" +
                                        $"Last Name: {reader["LastName"]}\n" +
                                        $"Phone Number: {reader["PhoneNumber"]}\n" +
                                        $"Email: {reader["Email"]}\n" +
                                        $"Address: {reader["Address"]}\n" +
                                        $"City: {reader["City"]}\n" +
                                        $"State: {reader["State"]}\n" +
                                        $"Zip Code: {reader["ZipCode"]}");

                    
                }
            }
            
        }
        public static void UpdateD(string originalFirstName, string originalLastName, Contacts newContacts)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    string query = "UPDATE Address__Books SET FirstName=@NewFirstName, LastName=@NewLastName, PhoneNumber=@NewPhoneNumber, Email=@NewEmail, Address=@NewAddress, City=@NewCity, State=@NewState, ZipCode=@NewZipCode WHERE FirstName=@OriginalFirstName AND LastName=@OriginalLastName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NewFirstName", newContacts.FirstName);
                        cmd.Parameters.AddWithValue("@NewLastName", newContacts.LastName);
                        cmd.Parameters.AddWithValue("@NewPhoneNumber", newContacts.PhoneNumber);
                        cmd.Parameters.AddWithValue("@NewEmail", newContacts.Email);
                        cmd.Parameters.AddWithValue("@NewAddress", newContacts.Address);
                        cmd.Parameters.AddWithValue("@NewCity", newContacts.City);
                        cmd.Parameters.AddWithValue("@NewState", newContacts.State);
                        cmd.Parameters.AddWithValue("@NewZipCode", newContacts.ZipCode);
                        cmd.Parameters.AddWithValue("@OriginalFirstName", originalFirstName);
                        cmd.Parameters.AddWithValue("@OriginalLastName", originalLastName);

                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            Console.WriteLine("Update successful");
                        }
                        else
                        {
                            Console.WriteLine("Update failed");
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteD(String Firstname,string Lastname)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    string query = "delete from Address__Books where Firstname=@FirstName and Lastname=@LastName";

                    SqlCommand cmd =new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FirstName",Firstname);
                    cmd.Parameters.AddWithValue("@LastName",Lastname);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Delete successful");
                    }
                    else
                    {
                        Console.WriteLine("not delete successful");
                    }

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
