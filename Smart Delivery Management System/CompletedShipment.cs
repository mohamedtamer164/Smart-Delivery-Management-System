using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal  class CompletedShipment : Shipment
    {
        public CompletedShipment(
           string trackingCode,
           string description,
           decimal weight,
           decimal deliveryFee,
           DeliveryAddress destination)
           : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
            Console.WriteLine("Status : Completed");
        }
    }
}
