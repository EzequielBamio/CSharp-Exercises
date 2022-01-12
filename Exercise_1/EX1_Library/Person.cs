using System;

namespace EX1_Library
{
    public delegate void DelegateString(string msg);

    public class Person
    {
        public event DelegateString EventString;

        private string lastName;
        private string name;

        public string LastName 
        {
            get 
            {
                return this.lastName;
            }
            set 
            {
                if (value != this.lastName) 
                {
                    this.lastName = value;
                    this.EventString.Invoke(this.Show());
                }
            }
        }
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    this.EventString.Invoke(this.Show());
                }
            }
        }

        public Person() 
        {
            this.lastName = string.Empty;
            this.name = string.Empty;
        }

        public string Show() 
        {
            return $"Name: { this.Name }, Last Name: { this.LastName }";
        }


    }
}
