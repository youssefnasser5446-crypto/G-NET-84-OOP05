using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession05OOP
{
    public partial class Shipment
    {
        private string trackingStatus;

        public string TrackingStatus
        {
            set { trackingStatus = value; }

            get
            {
                if (!string.IsNullOrWhiteSpace(trackingStatus))
                    return trackingStatus;
                return "no tracking Status";
            }
        }

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string status)
        {
            if (!string.IsNullOrWhiteSpace(status))
            {
                OnTrackingStatusChanged(status);
                TrackingStatus = status;
            }
        }
        public partial void OnTrackingStatusChanged(string newStatus);
        


    }
}
