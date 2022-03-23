namespace Taxi
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Taxi taxi = new();
            taxi.DriverName = "Budi";
            taxi.OnDuty = true;
            taxi.NumPassengger = 3;
            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }
}