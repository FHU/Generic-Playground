using System;

namespace GenericPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> intSet = new Set<int>();
            intSet.Add(1);
            intSet.Add(2);
            intSet.Add(3);
            intSet.Add(4);

            intSet.Add(1);
            intSet.Add(1);

            Console.WriteLine("Cardinality: " + intSet.Cardinality);

            Set<string> stringSet = new Set<string>();
            stringSet.Add("Jeremy");
            stringSet.Add("Joshua");
            stringSet.Add("Josh");
            stringSet.Add("Jeremy");
            stringSet.Add("Asher");
            stringSet.Add("Cam");
            stringSet.Add("Sid");
            stringSet.Remove("Jeremy");

            Console.WriteLine("Cardinality: " + stringSet.Cardinality);


            Set<Person> personSet = new Set<Person>();
            Person j1 = new Person() { 
                FirstName="Jeremy", LastName="Beard"}; 
            Person j2 = new Person() { 
                FirstName="Jeremy", LastName="Beard"};

            personSet.Add(j1);
            personSet.Add(j2);


            Console.WriteLine("Cardinality: " + personSet.Cardinality);


            foreach( var e in stringSet ) {
                Console.WriteLine(e);
            } 

        }



    }
}
