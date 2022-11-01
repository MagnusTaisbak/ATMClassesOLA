using System;
namespace Classes
{
    public class Client
    {
       
        //Attribute
        public string FirstName { get; }
        public string LastName { get; }
        public string HomeAddress { get; }

        //constructor
        public Client(string firstName, string lastName, string homeAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            HomeAddress = homeAddress;
        }

    }
}

