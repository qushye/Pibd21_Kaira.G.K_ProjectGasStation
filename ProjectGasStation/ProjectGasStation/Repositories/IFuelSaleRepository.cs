using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Repositories
{
    public interface IFuelSaleRepository
    {
        IEnumerable<FuelSale> ReadFuelSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? sellerId = null, WorkShift? workShift = null);

        void CreateFuelSale(FuelSale fuelSale);
    }
}