using System;

namespace SOLID.VehicleCheck.Good
{
    public class ElectricVehicle : IElectricVehicle
    {
        public bool IsTyrePressureOk()
        {
            return true;
        }

        public bool IsBatteryOk()
        {
            return true;
        }
    }
}
