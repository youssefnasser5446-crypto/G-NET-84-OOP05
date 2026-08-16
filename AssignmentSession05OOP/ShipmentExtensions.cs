using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession05OOP
{
    public static class ShipmentExtensions
    {
       // Delivered
       public static string GetSummary(this Shipment shipment)
        {           
            
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
           // ITrackable track = (ITrackable)shipment;
           if (shipment.GetTrackingStatus().Contains("Delivered"))
                return true;
           return false;

        }
    }
}
