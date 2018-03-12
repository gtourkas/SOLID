using System;

namespace SOLID.VehicleCheck.Bad
{
    public class ElectricCar : IVehicle
    {
        public bool IsTyrePressureOk()
        {
            return true;
        }

        public bool IsEngineOilOk()
        {
            throw new NotSupportedException("electric vehicles have no internal combustion engine");
        }
    }
}
