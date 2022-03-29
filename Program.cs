namespace Taxi
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Taxi taxi = new();
            string driverName;
            bool onDuty;
            int numPass = 0;
            while (true)
            {
                Console.Write("Driver Name: ");
                driverName = Console.ReadLine();
                Console.Write("On Duty [yes or no]:");
                string duty = Console.ReadLine();
                if (!bool.TryParse(duty, out onDuty))
                {
                    if (duty.ToLower() == "yes") onDuty = true;
                    else if (duty.ToLower() == "no") onDuty = false;
                    else
                    {
                        DisplayError("Masukkan nilai [yes/no] atau [true/false]");
                        continue;
                    }
                }
                if (onDuty)
                {
                    Console.Write("Number of Passenger:");
                    string num = Console.ReadLine();
                    if (!int.TryParse(num, out numPass))
                    {
                        DisplayError("Masukkan nilai angka yang valid");
                        continue;
                    }
                }
                Thread.Yield();
                break;
            }           
            taxi.DriverName = driverName;
            taxi.OnDuty = onDuty;
            taxi.NumPassengger = numPass;
            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
        private static void DisplayError(string errorReason)
        {
            Console.WriteLine(errorReason);
            Console.WriteLine("Silahakan tekan sembarang tombol untuk mengulang");
            Console.ReadKey();
            Console.Clear();
        }
    }
}