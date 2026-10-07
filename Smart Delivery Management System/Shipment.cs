using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal abstract class Shipment
    {

        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode // Read-only property ان هو يقرا الداتا بس ما يكتبها
        {
            get { return trackingCode; }
        }

        public string Description // Read-write property ان هو يقرا الداتا ويكتبها
                                  // بس شرط انها متكونش  Null او Empty
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }

        }
        public decimal Weight // Read-write property ان هو يقرا الداتا ويكتبها
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee // Read-only property ان هو يقرا الداتا بس ما يكتبها
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; } // Read-write property ان هو يقرا الداتا ويكتبها
        public abstract decimal EstimatedCost { get; }
        public Shipment()
        {

        }
        public Shipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                trackingCode = "Unknown";
            }

            this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                trackingCode = "Unknown";
            }

            this.trackingCode = trackingCode;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

        }

        public void UpdateDeliveryFee(decimal newFee) // دي method بتغير ال DeliveryFee 
        {
            if (newFee > 0) // هنا اني ف كل مره هحط شرط ان ال DeliveryFee لازم يكون اكبر من 0
            {
                DeliveryFee = newFee;  // هنا اني ف كل مره هحط شرط ان ال DeliveryFee لازم يكون اكبر من 0
            }
        }
        // Assignment 03 - Overloading
        public void UpdateWeight(decimal newWeight) //بص هو كل متغير من الي فوق ف هو اكيد هيتغير ف انا بعمله داله عشان لما يتغير ف كمان حجز جوا متغير كدا هزوده بيها 
        {
            if (newWeight > 0) // هنا اني ف كل مره هحط شرط ان ال Weight لازم يكون اكبر من 0
            {
                Weight = newWeight;
            }
        }
        public void UpdateWeight(decimal newWeight, decimal packingWeight) // هنا هو زود وزن زياده علي الوزن التاني 
        {
            decimal totalWeight = newWeight + packingWeight;

            if (totalWeight > 0)
            {
                Weight = totalWeight;
            }
        }
        // Assignment 03 - virtual
        public abstract void PrintShipment();
    }
}
