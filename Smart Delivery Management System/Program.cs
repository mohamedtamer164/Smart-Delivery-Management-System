namespace Smart_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("     Smart Delivery Management System");
            Console.WriteLine("==========================================");

            // 1. Create Driver
            Driver driver = new Driver("Ahmed Mohamed"); //  هنا حجزنا اسم ال سواق

            // 2. Create Delivery Center
            DeliveryCenter center =
                new DeliveryCenter("Main Delivery Center"); 

            // 3. Assign Driver
            center.Driver = driver;

            // Address 1
            DeliveryAddress address1 =
                new DeliveryAddress(
                    "Cairo",
                    "Tahrir Street",
                    15);

            // Address 2
            DeliveryAddress address2 =
                new DeliveryAddress(
                    "Giza",
                    "Pyramids Street",
                    20);

            // Address 3
            DeliveryAddress address3 =
                new DeliveryAddress(
                    "Cairo",
                    "Nasr City",
                    10);

            // 4. Standard Shipment
            StandardShipment standard =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    80,
                    address1);

            // 5. Express Shipment
            ExpressShipment express =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    address2,
                    30);

            // 6. International Shipment
            InternationalShipment international =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    8,
                    120,
                    address3,
                    "Germany",
                    100);

            // 7. Add Shipments
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // 8. Print all
            Console.WriteLine();
            Console.WriteLine("Printing All Shipments...");
            center.PrintAllShipments();

            // 9. DeliveryHelper
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine("==========================================");

            DeliveryHelper.PrintShipmentDetails(standard);

            Console.WriteLine("------------------------------------------");

            DeliveryHelper.PrintShipmentDetails(express);

            Console.WriteLine("------------------------------------------");

            DeliveryHelper.PrintShipmentDetails(international);

            // 10. UpdateWeight Overloading
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Updating Weight...");
            Console.WriteLine("==========================================");

            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            standard.UpdateWeight(5, 0.5m);

            Console.WriteLine(
                $"Updated Weight After Packing : {standard.Weight} KG");

            // 11. Mixed Shipment Array
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine("==========================================");

            Shipment[] shipments =
            {
                standard,
                express,
                international
            };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();

                Console.WriteLine("------------------------------------------");
            }

            // 12. Sealed Class demonstration
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Sealed Class / Sealed Method...");
            Console.WriteLine("==========================================");

            CompletedShipment completed =
                new CompletedShipment(
                    "SH004",
                    "Keyboard",
                    1,
                    40,
                    address1);

            completed.PrintShipment();

            Console.WriteLine("------------------------------------------");

            PriorityInternationalShipment priority =
                new PriorityInternationalShipment(
                    "SH005",
                    "Camera",
                    4,
                    150,
                    address3,
                    "France",
                    80);

            priority.GenerateCustomsReport();

            Console.WriteLine();
            Console.WriteLine("Program Finished.");
        }
    }
    }


