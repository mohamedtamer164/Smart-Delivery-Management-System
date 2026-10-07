using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class InternationalShipment : Shipment
    {
        public string DestinationCountry { get; set; }

        public decimal CustomsFee { get; set; }
        public InternationalShipment()
            { }
        public InternationalShipment(
       string trackingCode,
       string description,
       decimal weight,
       decimal deliveryFee,
       DeliveryAddress destination,
       string destinationCountry,
       decimal customsFee)
       : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (!string.IsNullOrWhiteSpace(destinationCountry))
            {
                DestinationCountry = destinationCountry;
            }
            else
            {
                DestinationCountry = "Unknown";
            }

            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
            else
            {
                CustomsFee = 0;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");

        }
        // Assignment 03 - Virtual Method
        public virtual void GenerateCustomsReport() 
        {
            Console.WriteLine($"Customs Report for {TrackingCode}");
            Console.WriteLine($"Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
        }
    }
}
