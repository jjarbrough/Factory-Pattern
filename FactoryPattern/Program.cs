namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does the vehicle have?");
            int numtires = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.GetVehicle(numtires);
            vehicle.Drive();
        }
        
    }
}
