namespace SOLID.VehicleCheck.Bad
{
    public class Car : IVehicle
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
