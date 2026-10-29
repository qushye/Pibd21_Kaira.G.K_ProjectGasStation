namespace ProjectGasStation.Entities.Enums
{
    [Flags]
    public enum FuelType
    {
        None = 0,

        Petrol = 1,

        Diesel = 2,

        Gas = 4,

        Material = 8
    }
}