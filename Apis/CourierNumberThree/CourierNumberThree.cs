using ShipmentCourierInterface;
using System;

namespace CourierNumberThree
{
    public class CourierNumberThreeApi
    {
        public void CreateShipmentAndGetWayBill()
        {
            Console.WriteLine("Hello from CreateShipmentAndGetWayBill => Courier number three");
        }
        public void RegisterNumberToGetWayBill()
        {
            Console.WriteLine("Hello from RegisterNumberToGetWayBill => Courier number three");
        }
        public void GetTrackingDetails()
        {
            Console.WriteLine("Hello from GetTrackingDetails => Courier number three");
            Console.WriteLine("========================================================");
        }
    }

    public class CourierNumberThreeApiWrapper : IShipmentCourier
    {
        private readonly CourierNumberThreeApi _courierApi;

        public CourierNumberThreeApiWrapper() => _courierApi = new CourierNumberThreeApi();

        public void CreateShipment() => _courierApi.CreateShipmentAndGetWayBill();

        public void TrackShipment()
        {
            _courierApi.RegisterNumberToGetWayBill();
            _courierApi.GetTrackingDetails();
        }
    }
}
