using ShipmentCourierInterface;
using System;

namespace CourierNumberOne
{
    public class CourierNumberOneApi
    {
        public void CreateShipmentAndGetWayBill()
        {
            Console.WriteLine("Hello from CreateShipmentAndGetWayBill => Courier number one");
        }
        public void GetShipmentTrackingDetails()
        {
            Console.WriteLine("Hello from GetShipmentTrackingDetails => Courier number one");
            Console.WriteLine("========================================================");
        }
    }

    public class CourierNumberOneApiWrapper : IShipmentCourier
    {
        private readonly CourierNumberOneApi _courierApi;

        public CourierNumberOneApiWrapper() => _courierApi = new CourierNumberOneApi();

        public void CreateShipment() => _courierApi.CreateShipmentAndGetWayBill();
        public void TrackShipment() => _courierApi.GetShipmentTrackingDetails();
    }
}