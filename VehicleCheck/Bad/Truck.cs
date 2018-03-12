using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.VehicleCheck.Bad
{
    public class Truck : IVehicle
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
