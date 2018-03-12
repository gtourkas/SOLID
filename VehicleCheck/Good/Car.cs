namespace SOLID.VehicleCheck.Good
{
    public class ConventionalVehicle : IConventionalVehicle
    {
        public bool IsTyrePressureOk()
        {
            return true;
        }

        public bool IsEngineOilOk()
        {
            return true;
        }

    }
}
