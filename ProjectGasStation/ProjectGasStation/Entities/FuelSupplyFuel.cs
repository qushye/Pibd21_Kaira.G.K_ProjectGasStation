namespace ProjectGasStation.Entities
{
    public class FuelSupplyFuel
    {
        public int Id { get; private set; }

        public int FuelId { get; private set; }

        public int Count { get; private set; }

        public static FuelSupplyFuel CreateElement(int id, int fuelId, int count)
        {
            return new FuelSupplyFuel
            {
                Id = id,
                FuelId = fuelId,
                Count = count
            };
        }
    }
}