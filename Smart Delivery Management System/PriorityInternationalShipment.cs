using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
         string trackingCode,
         string description,
         decimal weight,
         decimal deliveryFee,
         DeliveryAddress destination,
         string destinationCountry,
         decimal customsFee)
         : base(
             trackingCode,
             description,
             weight,
             deliveryFee,
             destination,
             destinationCountry,
             customsFee)
        {
        }
        public sealed override void GenerateCustomsReport() // مفيش حد هيقدر ياخد ذلك ال ميثود بعد كدا
        {
            Console.WriteLine("Priority Customs Report");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
            Console.WriteLine("Priority Processing: Enabled");
        }
    }
}
