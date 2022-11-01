using System;
using System.Collections.Generic;
using System.Text;

namespace Lektionsövning
{
    class Customer
    {
        private int id = 0;
        private string firstname = "";
        private string lastname = "";
        private string email = "";


        public Customer(int id, string firstname, string lastname, string email)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }
        public Customer()
        {

        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ID får inte vara negativt");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(firstname))
                {
                    return "Name has no value";
                }
                return firstname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You need to provide a value");
                }
                else
                {
                    this.firstname = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(lastname))
                {
                    return "Lastname has no value";
                }
                return lastname; ;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You need to provide a value");
                }
                else
                {
                    this.lastname = value;
                }
            }
        }

        public string Email
        {
            get
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    return "Email has no value";
                }
                return email; ;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You have to provide a value");
                }
                else
                {
                    this.email = value;
                }
            }
        }
        public override string ToString()
        {
            return "ID: " + ID + " Firstname: " + FirstName + " Lastname: " + LastName + " Email: " + Email;
        }
    }
}

