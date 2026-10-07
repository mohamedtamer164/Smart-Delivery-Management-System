using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    internal class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            {
                if (extraFee >= 0)
                {
                    ExtraFee = extraFee;
                }
                else
                {
                    ExtraFee = 0;
                }
            }


        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee; // هنضيف هنا
            }
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
        }
    }
}
