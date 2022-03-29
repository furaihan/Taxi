namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassengger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine($"Driver Name: {DriverName}");
            Console.WriteLine($"On Duty: {(OnDuty ? "Yes" : "No")}");
            Console.WriteLine($"Number of Passenger: {NumPassengger}");
        }
        public void PickupPassenger()
        {
            if (OnDuty) Console.WriteLine($"{DriverName} sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            if (OnDuty) Console.WriteLine($"{DriverName} selesai mengantar penumpang");
        }
    }
}
