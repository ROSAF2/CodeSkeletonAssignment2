using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkeleton
{
    public abstract class Person
    {
        //Fields
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNUmber;
        private string email;
        //Constructor
        public Person()
        { }
        //Methods
        public abstract void NegotiateSpecializedTour();
    }
}
