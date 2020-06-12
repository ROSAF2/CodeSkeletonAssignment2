using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkeleton
{
    public class Customer : Person
    {
        //Fields
        private int userID;
        private string password;
        private List<string> paymentDetails;
        private List<string> IRDDetails;
        private List<Booking> bookings; 
        //Constructor
        public Customer()
        { }
        //Methods
        public void ContactBusiness()
        { }
        public override void NegotiateSpecializedTour()
        { }
        public void MakePayment()
        { }
        public void EnterCredentials()
        { }
        public void RegisterOnWebsite()
        { }
        public void SelectTour()
        { }
        public void SelectPackage()
        { }
        public void AcceptTourPolicy()
        { }
        public void SavePaymentDetails()
        { }
        public void SaveIRDDetails()
        { }
        public void ArrangeServices()
        { }
        public void EnjoyTour()
        { }
    }
}
