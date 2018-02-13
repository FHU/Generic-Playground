﻿using System;
namespace GenericPlayground
{
    public class Person: IEquatable<Person> 
    {
        public Person()
        {
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public bool Equals(Person other)
        {
            return (FirstName == other.FirstName) && (LastName == other.LastName);
        }
    }
}
