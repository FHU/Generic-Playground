using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericPlayground
{
    public class Set<T>: IEnumerable
    {
        List<T> values = new List<T>();

        public Set()
        {
        }

        public void Add(T element) {
            //look through the values array and add the new value to the end 
            // if it's not already present. 

            if( !values.Contains(element) ) {
                values.Add(element);
            }
        }

        public void Remove(T element) {
            //look throuhg the values array and remove specified value.

            values.Remove(element);
        }

        public bool Contains(T element) {
            return values.Contains(element);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var el in values) {
                yield return el;
            }
        }

        public int Cardinality{
            get {
                return values.Count;
            }
        }

        public bool IsEmpty
        {
            get {
                return (values.Count == 0);
            }
        }
    }

}
