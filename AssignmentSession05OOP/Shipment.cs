using AssignmentSession05OOP.inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession05OOP
{
    public abstract partial class Shipment : ICloneable
    {

        private string? trackingCode;
        private string? description;
        private decimal weight;
        private decimal deliveryFee;
        public static int TotalShipmentsCreated;
         static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized\n");
        }
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        public Shipment()
        {

            trackingStatus = "Under Review";
            TotalShipmentsCreated++;
            Destination = null!;
        }
        public Shipment(string? _trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(_trackingCode))
            {
                TrackingCode = _trackingCode;
            }
            trackingStatus = "Under Review";
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = null!;
        }
        public Shipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee)
        {
            if (!string.IsNullOrWhiteSpace(_trackingCode))
            {
                TrackingCode = _trackingCode;
            }       
            Description = _description;
            Weight = _weight;
            DeliveryFee = _deliveryFee;
            TotalShipmentsCreated++;
            trackingStatus = "Under Review";
            Destination = null!;
        }
        public Shipment(string? _trackingCode, string _description, 
            decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
            : this(_trackingCode, _description, _weight, _deliveryFee)
        {
            Destination = _destination;       
        }

        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();
        public DeliveryAddress Destination { set; get; }

        public partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }

        public string TrackingCode
        {
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }

            get
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    return trackingCode;
                else
                    return "";
            }
        }
        public string Description
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
            get
            {
                if (description is not null)
                    return description;
                else
                    return "no description";
            }
        }
        public decimal Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }

            get
            {
                return weight;
            }
        }

        public decimal DeliveryFee
        {
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
            get
            {
                return deliveryFee;
            }
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }

        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight >= 0)
            {
                weight = newWeight + packingWeight;
            }

        }
        
        public Shipment CopyShipment()
        {
            return new StandardShipment(TrackingCode,
        Description,
        Weight,
        DeliveryFee,
         Destination

        );        
        }
        public Shipment ShallowCopy()
        {
           return (Shipment)Clone();
        }

        public Shipment DeepCopy()
        {
            Shipment deep = ShallowCopy();
            deep.Destination = new DeliveryAddress(deep.Destination.city,deep.Destination.street,deep.Destination.BuildingNumber);
            return deep;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }       
    }
}
