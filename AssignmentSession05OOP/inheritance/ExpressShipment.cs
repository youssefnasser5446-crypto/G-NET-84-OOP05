using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession05OOP.inheritance
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        decimal extraFee;
        public ExpressShipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee, decimal _extraFee, DeliveryAddress _address)
            : base(_trackingCode, _description, _weight, _deliveryFee, _address)
        {
            ExtraFee = _extraFee;
            TrackingStatus = "Out For Delivery";

        }
         string ITrackable.GetTrackingStatus()
        {
            return $"Shipment SH002 is Out for Delivery.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost { get => DeliveryFee + (Weight * 5 )+ ExtraFee; }
        public override void PrintShipment()
        {
            Console.WriteLine($" trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee}  \n ExtraFee : {ExtraFee} \n " +
                        $" Estimated cost : {EstimatedCost} ");
        }

        
    }
}
