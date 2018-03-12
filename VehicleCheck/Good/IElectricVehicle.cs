namespace SOLID.VehicleCheck.Good
{
    public interface IElectricVehicle
    {
        bool IsTyrePressureOk();

        bool IsBatteryOk();
    }
}
