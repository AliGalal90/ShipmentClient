using ShipmentCourierInterface;

namespace ShipmentClient
{
    public class CourierClient : IShipmentCourier
    {
        private readonly IShipmentCourier _shipmentCourier;

        public CourierClient(IShipmentCourier shipmentCourier) => _shipmentCourier = shipmentCourier;

        public void CreateShipment() => _shipmentCourier.CreateShipment();
        public void TrackShipment() => _shipmentCourier.TrackShipment();
    }
}