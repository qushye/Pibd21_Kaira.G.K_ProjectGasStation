namespace ProjectGasStation.Entities
{
    public class FuelSupply
    {
        public int Id { get; private set; }

        public int SupplierId { get; private set; }

        public int SellerId { get; private set; }

        public DateTime SupplyDate { get; private set; }

        public IEnumerable<FuelSupplyFuel> FuelSupplyFuels { get; private set; } = [];

        public static FuelSupply CreateOperation(int id, int supplierId, int sellerId, IEnumerable<FuelSupplyFuel> fuelSupplyFuels)
        {
            return new FuelSupply
            {
                Id = id,
                SupplierId = supplierId,
                SellerId = sellerId,
                SupplyDate = DateTime.Now,
                FuelSupplyFuels = fuelSupplyFuels ?? []
            };
        }
    }
}