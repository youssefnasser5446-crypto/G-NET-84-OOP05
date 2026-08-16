using AssignmentSession05OOP.inheritance;

namespace AssignmentSession05OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
             a) What happens when you assign one object variable to another object variable?

            ans => Changes to the fields will be reflected in both, because they both point to the same object.

            b) Does assigning one object to another create a new object? Explain.

            ans => No. It makes both variables point to the same object;
            a modification through one variable will be reflected when accessing the object through the other.

            c) What is the difference between copying an object and copying its reference?

            ans => Copying an object means creating a new object on the heap and copying the data into it;
            modifications to one do not affect the other. However, 
            copying its reference results in the new reference pointing to the same object,
            so modifications to one are reflected in the other.

             */

            #endregion

            #region Question02

            /*
              a) What is a Shallow Copy?

            ans => It creates a new object and copies the values of all fields. 
            For value-type fields, the value itself is copied; for reference-type fields,
            the reference is copied, so both objects point to the same referenced object.

            b) What is a Deep Copy?

            ans => It copies the object's internal value-type data,
            but for internal references—such as nested objects—it creates a new object on the heap.

            c) What happens to reference-type members when a Shallow Copy is created?

            ans => It copies the address and points to the same object—except for strings, because they are immutable.

            d) What happens to reference-type members when a Deep Copy is created?

            ans => It creates a new object for this reference, making it independent of the original one.

            e) Give one situation where Deep Copy would be safer than Shallow Copy

            ans => When two objects need to be modified independently, 
            Deep Copy is safer because changes made to one object will not affect the other.

             */

            #endregion

            #region Question03

            /*
             a) What is a static field, and how is it different from an instance field?

            ans => A static field exists for the entire duration of the program; 
            any modification to it affects all instances because it is shared among them.
            In contrast, an instance field exists only at the object level for the lifetime of that specific object,
            and modifications to it do not affect other objects.

            b) What is a static method? Can a static method directly access instance members?

            ans => It is a method that is called directly using the class name, 
            without needing an object; it resides in memory for the entire duration of the program's execution, 
            and It cannot directly access instance members.

            c) What is a static constructor, and when is it executed?

            ans => It is executed automatically before accessing any static member 
            or creating the first instance of the class

            d) What is a static class? Can you create an object from a static class?

            ans => A static class is a class where all its members must be static;
            they are called directly using the class name, and you cannot create an object from it.

             */



            #endregion

            #region Question04

            /*
              a) What is an Extension Method?

            ans => It is a method extension that allows me to add a method 
            without modifying the original class—even if I don't have access to that class.

            b) What keyword must be used in the first parameter of an extension method?

            ans => The this keyword is followed by the type—such as a class name,
            a reference type, or a data type—and the corresponding variable, like this int x or this Person obj.

            c) Where must an extension method be declared?

            An extension method must be declared as a static method inside a static class.

            d) Can an extension method access private members of the class it extends?

            ans => No, an extension method cannot directly access private or protected members of the class it extends

                */

            #endregion

            #region Question05

            /*
              a) What is a Partial Class?

            ans => This is a class that allows for multiple definitions sharing the same name, type, and access modifier; 
            each part contains a portion of the code contains a portion of the code, yet during  compilation , they function as a single class.

            b) Why would a developer split one class into multiple files?

            When a class is large and you want multiple people working on it simultaneously,
            or you want to improve its readability—making it easier to read

            c) What is a Partial Method?

            ans => It is a method that requires its class to be partial. The method itself has no implementation;
            in the other partial part, you can choose whether or not to implement it.

            d) What happens if a declared partial method has no implementation?

            ans =>It compiles successfully, and if there is no implementation,
            the partial method declaration is removed by the compiler, so it cannot be called.

             */

            #endregion
           

            Console.WriteLine(" ==========================================");
            Console.WriteLine(" Smart Delivery Management System");
            Console.WriteLine(" ==========================================");
            DeliveryAddress address = new DeliveryAddress("Cairo", "street1",5);
            Shipment standard = new StandardShipment("SH001", "Laptop", 3, 80, address);
            Shipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30, address);
            Shipment international = new InternationalShipment("SH003", "Televition", 8, 120, "Germany", 100, address);

            Console.WriteLine("==========================================\n");
            Console.WriteLine("Creating Shipments...");
            Console.WriteLine("==========================================\n");
            Console.WriteLine("Standard Shipment is Created");
            Console.WriteLine("Express Shipment is Created");
            Console.WriteLine("International Shipment is Created");

            Console.WriteLine($"Total Shipments Created : {Shipment.TotalShipmentsCreated}");
           
            Console.WriteLine("==========================================");
            Console.WriteLine("Object Copying");
            Console.WriteLine("==========================================");

            Shipment shipmdent1 = standard.CopyShipment();
            Shipment shipmdent2 = shipmdent1;

            Console.WriteLine($"Original Shipment  : {shipmdent1.TrackingCode} ");
            Console.WriteLine($"Assigned  Shipment  : {shipmdent2.TrackingCode} ");

            Console.WriteLine($"Same Object : {ReferenceEquals(shipmdent1, shipmdent2)}");

            Console.WriteLine("==========================================");
            Console.WriteLine("Shallow Copy");
            Console.WriteLine("==========================================");

            Shipment shallowCopy = standard.CopyShipment();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            Console.WriteLine($"Copied  Shipment Address : {shallowCopy.Destination.city}\n");
            shallowCopy.Destination.city = "Giza";
            Console.WriteLine($"Changing copied shipment address...\n");
            Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            Console.WriteLine($"Copied  Shipment Address : {shallowCopy.Destination.city}\n");
            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, shallowCopy.Destination)}");
           
            Console.WriteLine("==========================================");
            Console.WriteLine("Deep Copy");
            Console.WriteLine("==========================================");
            Shipment DeepCopy = standard.DeepCopy();
            Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            Console.WriteLine($"Copied  Shipment Address : {DeepCopy.Destination.city}\n");
            Console.WriteLine("Changing copied shipment address...\n");
            DeepCopy.Destination.city = "Cairo";
            Console.WriteLine($"Original Shipment Address : {standard.Destination.city}");
            Console.WriteLine($"Copied  Shipment Address : {DeepCopy.Destination.city}\n");
            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, DeepCopy.Destination)}");

            Console.WriteLine("==========================================");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("==========================================");

            Console.WriteLine( standard.GetSummary());
            Console.WriteLine(express.GetSummary());
            Console.WriteLine(international.GetSummary());

            Console.WriteLine($"SH001 Is Delivered : {standard.IsDelivered()}");
            Console.WriteLine($"SH003 Is Delivered : {international.IsDelivered()}");

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");

            international.UpdateTrackingStatus("Out For Delivery");
            Console.WriteLine("After update ====== \n");
            Console.WriteLine(standard.GetSummary());
            Console.WriteLine(express.GetSummary());
            Console.WriteLine(international.GetSummary());

            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();
            DeliveryUtilities.PrintSeparator();


            DeliveryCenter DC = new DeliveryCenter();
            Console.WriteLine(DC.AddShipment(standard) ? "Shipment Added Succssfully" : "Shipment Not Added");
            Console.WriteLine(DC.AddShipment(express) ? "Shipment Added Succssfully" : "Shipment Not Added");
            Console.WriteLine(DC.AddShipment(international) ? "Shipment Added Succssfully" : "Shipment Not Added");

            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("Standard Shipment\n");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("Express Shipment\n");
            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine("\n=======================================\n");

            Console.WriteLine("International Shipment\n");
            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("\n=======================================\n");

            //Console.WriteLine("Tracking Status with interface array");

            //ITrackable[] Track = { standard, Express, international };

            //foreach (ITrackable x in Track)
            //{
            //    Console.WriteLine(x.GetTrackingStatus());
            //}

            //IInsurable[] Insurable = { standard, Express, international };
            //Console.WriteLine("\n=======================================\n");

            //foreach (IInsurable x in Insurable)
            //{
            //    if (x is StandardShipment)
            //        Console.WriteLine($"Standard Shipment Insurance : {x.CalculateInsurance()} EGP");

            //    if (x is ExpressShipment)
            //        Console.WriteLine($"Express Shipment Insurance : {x.CalculateInsurance()} EGP");

            //    if (x is InternationalShipment)
            //        Console.WriteLine($"International Shipment Insurance : {x.CalculateInsurance()} EGP");
            //}
            //Console.WriteLine("\n=======================================\n");
            //Console.WriteLine("\nTracking Status with DeliveryReport \n");

            //DeliveryReport report = new DeliveryReport();
            //report.PrintShipment(standard);
            //report.PrintShipment(Express);
            //report.PrintShipment(international);
            //Console.WriteLine("\n=======================================\n");

            //Console.WriteLine("\nPrint Insurance Status with DeliveryReport \n");
            //Console.Write("Standard Shipment Insurance : "); report.PrintInsurance(standard); Console.Write(" EGP\n");
            //Console.Write("Express Shipment Insurance : "); report.PrintInsurance(Express); Console.Write(" EGP\n");
            //Console.Write("International Shipment Insurance : "); report.PrintInsurance(international); Console.Write(" EGP\n");


            //Console.WriteLine("\n=======================================\n");
            //Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");


        }
    }
}
