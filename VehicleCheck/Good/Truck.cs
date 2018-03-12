namespace SOLID.VehicleCheck.Good
{
    public class Truck : IConventionalVehicle
    {
        public bool IsEngineOilOk()
        {
            return true;
        }

        public bool IsTyrePressureOk()
        {
            return true;
        }
    }
}
