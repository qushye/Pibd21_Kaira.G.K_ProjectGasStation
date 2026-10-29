using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class FuelSupplyRepository : IFuelSupplyRepository
    {
        public void CreateFuelSupply(FuelSupply fuelSupply)
        {
        }

        public void DeleteFuelSupply(int id)
        {
        }

        public IEnumerable<FuelSupply> ReadFuelSupplies(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? supplierId = null, int? sellerId = null)
        {
            return [];
        }
    }
}