namespace Builder
{

    internal abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; private set; }

        public VehicleBuilder(VehicleType vehicleType)
        {
            Vehicle = new Vehicle(vehicleType);
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}