using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Data;
using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class FuelSaleRepository : IFuelSaleRepository
    {
        private readonly DataContext _context;

        private readonly ILogger<FuelSaleRepository> _logger;

        public FuelSaleRepository(DataContext context, ILogger<FuelSaleRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<FuelSale> ReadFuelSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? sellerId = null, WorkShift? workShift = null)
        {
            _logger.LogDebug(
                "Получение продаж ГСМ с фильтрами: dateFrom={DateFrom}, dateTo={DateTo}, fuelId={FuelId}, sellerId={SellerId}, workShift={WorkShift}",
                dateFrom,
                dateTo,
                fuelId,
                sellerId,
                workShift);

            try
            {
                IQueryable<FuelSale> query = _context.FuelSales
                    .AsNoTracking()
                    .Include(e => e.Fuel)
                    .Include(e => e.Seller);

                if (dateFrom.HasValue)
                {
                    query = query.Where(e => e.SaleDate >= dateFrom.Value);
                }

                if (dateTo.HasValue)
                {
                    query = query.Where(e => e.SaleDate <= dateTo.Value);
                }

                if (fuelId.HasValue)
                {
                    query = query.Where(e => e.FuelId == fuelId.Value);
                }

                if (sellerId.HasValue)
                {
                    query = query.Where(e => e.SellerId == sellerId.Value);
                }

                if (workShift.HasValue)
                {
                    query = query.Where(e => e.WorkShift == workShift.Value);
                }

                var sales = query.OrderByDescending(e => e.SaleDate).ToList();
                _logger.LogInformation("Получено {Count} записей продаж ГСМ", sales.Count);
                return sales;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении продаж ГСМ");
                throw;
            }
        }

        public void CreateFuelSale(FuelSale fuelSale)
        {
            _logger.LogInformation("Добавление продажи ГСМ {@FuelSale}", fuelSale);
            try
            {
                _context.FuelSales.Add(fuelSale);
                _context.SaveChanges();
                _logger.LogInformation("Продажа ГСМ добавлена, Id={FuelSaleId}, сумма={TotalSum}", fuelSale.Id, fuelSale.TotalSum);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении продажи ГСМ {@FuelSale}", fuelSale);
                throw;
            }
        }
    }
}
