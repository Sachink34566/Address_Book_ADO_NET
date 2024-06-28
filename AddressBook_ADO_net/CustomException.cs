using System;

namespace Address_Books
{
    public class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {
        }

        public class InvalidNameException : CustomException
        {
            public InvalidNameException() : base("Please enter a correct name.")
            {
            }
        }

        public class InvalidAddressException : CustomException
        {
            public InvalidAddressException() : base("Enter a valid address.")
            {
            }
        }

        public class InvalidNumberException : CustomException
        {
            public InvalidNumberException() : base("The entered number is not in the correct format!")
            {
            }
        }

        public class InvalidZipException : CustomException
        {
            public InvalidZipException() : base("Enter a correct zip code.")
            {
            }
        }

        public class InvalidStateException : CustomException
        {
            public InvalidStateException() : base("Enter a correct state format.")
            {
            }
        }

        public class InvalidCityException : CustomException
        {
            public InvalidCityException() : base("Enter a correct city name.")
            {
            }
        }

        public class InvalidEmailException : CustomException
        {
            public InvalidEmailException() : base("Enter a correct email.")
            {
            }
        }

        public class AlreadyExistsException : CustomException
        {
            public AlreadyExistsException() : base("This person already exists in the address book.")
            {
            }
        }

        public class UpdateDataDBException : CustomException
        {
            public UpdateDataDBException() : base("Failed to update data in the database.")
            {
            }
        }
    }
}
