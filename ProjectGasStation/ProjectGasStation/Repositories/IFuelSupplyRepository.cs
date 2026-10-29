using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories
{
    public interface IFuelSupplyRepository
    {
        IEnumerable<FuelSupply> ReadFuelSupplies(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? supplierId = null, int? sellerId = null);

        void CreateFuelSupply(FuelSupply fuelSupply);

        void DeleteFuelSupply(int id);
    }
}