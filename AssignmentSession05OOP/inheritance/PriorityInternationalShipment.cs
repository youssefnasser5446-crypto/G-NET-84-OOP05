using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession05OOP.inheritance
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public override sealed void GenerateCustomsReport()
        {
            Console.WriteLine("Generating Priority international customs report...");
        }
    }
}
