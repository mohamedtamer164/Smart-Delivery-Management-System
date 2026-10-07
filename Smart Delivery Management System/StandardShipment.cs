using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class StandardShipment :Shipment 
    {
        public StandardShipment(
           string trackingCode,
           string description,
           decimal weight,
           decimal deliveryFee,
           DeliveryAddress destination)
           : base(trackingCode, description, weight, deliveryFee, destination) // بستخدمها عشان تنقل الي هناك هنا بدون م اكرر  hg behevoir
        {
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
        }
    }
}
