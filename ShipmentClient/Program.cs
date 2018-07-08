using CourierNumberFour;
using CourierNumberOne;
using CourierNumberThree;
using CourierNumberTwo;
using System;

namespace ShipmentClient
{
    internal class Program
    {
        private static CourierClient courierClient;

        private static void Main(string[] args)
        {
            courierClient = new CourierClient(new CourierNumberOneApiWrapper());
            ProcessShipment(courierClient);

            courierClient = new CourierClient(new CourierNumberTwoApiWrapper());
            ProcessShipment(courierClient);

            courierClient = new CourierClient(new CourierNumberThreeApiWrapper());
            ProcessShipment(courierClient);

            courierClient = new CourierClient(new CourierNumberFourApiWrapper());
            ProcessShipment(courierClient);

            Console.ReadKey();
        }

        private static void ProcessShipment(CourierClient courierClient)
        {
            courierClient.CreateShipment();
            courierClient.TrackShipment();
        }
    }
}