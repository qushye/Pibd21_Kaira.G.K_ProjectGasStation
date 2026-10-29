using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class FuelSaleRepository : IFuelSaleRepository
    {
        public void CreateFuelSale(FuelSale fuelSale)
        {
        }

        public IEnumerable<FuelSale> ReadFuelSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? sellerId = null, WorkShift? workShift = null)
        {
            return [];
        }
    }
}