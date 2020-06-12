using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkeleton
{
    class Booking
    {
        //Fields
        private int bookingID;
        private Customer customer;
        private string selectedTour;
        private string bookingDate;
        private string tourDate;
        private PackageDeal selectedPackage;
        private List<Service> extraArrangements;
        private double bookingCost;
        private bool bookingPaid;
        //Constructor
        public Booking()
        { }
        //Methods
        public void CalculateBookingCost()
        { }
        public void CalculateTenPercent()
        { }
    }
}
