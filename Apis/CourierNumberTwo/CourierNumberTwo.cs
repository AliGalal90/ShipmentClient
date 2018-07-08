using ShipmentCourierInterface;
using System;

namespace CourierNumberTwo
{
    public class CourierNumberTwoApi
    {
        public void CreateShipmentInfo()
        {
            Console.WriteLine("Hello from CreateShipmentInfo => Courier number two");
        }
        public void CreateShipmentInstructions()
        {
            Console.WriteLine("Hello from CreateShipmentInfo => Courier number two");
        }
        public void GetShimpmentWayBill()
        {
            Console.WriteLine("Hello from GetShimpmentWayBill => Courier number two");
        }
        public void GetShipmentTrackingDetails()
        {
            Console.WriteLine("Hello from GetShipmentTrackingDetails => Courier number two");
            Console.WriteLine("========================================================");
        }
    }

    public class CourierNumberTwoApiWrapper : IShipmentCourier
    {
        private readonly CourierNumberTwoApi _courierApi;

        public CourierNumberTwoApiWrapper() => _courierApi = new CourierNumberTwoApi();

        public void CreateShipment()
        {
            _courierApi.CreateShipmentInfo();
            _courierApi.CreateShipmentInstructions();
            _courierApi.GetShimpmentWayBill();
        }

        public void TrackShipment() => _courierApi.GetShipmentTrackingDetails();
    }
}