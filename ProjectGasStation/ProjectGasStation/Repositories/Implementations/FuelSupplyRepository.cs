using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Data;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class FuelSupplyRepository : IFuelSupplyRepository
    {
        private readonly DataContext _context;

        private readonly ILogger<FuelSupplyRepository> _logger;

        public FuelSupplyRepository(DataContext context, ILogger<FuelSupplyRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<FuelSupply> ReadFuelSupplies(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? supplierId = null, int? sellerId = null)
        {
            _logger.LogDebug(
                "Получение поставок ГСМ с фильтрами: dateFrom={DateFrom}, dateTo={DateTo}, fuelId={FuelId}, supplierId={SupplierId}, sellerId={SellerId}",
                dateFrom,
                dateTo,
                fuelId,
                supplierId,
                sellerId);

            try
            {
                IQueryable<FuelSupply> query = _context.FuelSupplies
                    .AsNoTracking()
                    .Include(e => e.Supplier)
                    .Include(e => e.Seller)
                    .Include(e => e.FuelSupplyFuels)
                        .ThenInclude(e => e.Fuel);

                if (dateFrom.HasValue)
                {
                    query = query.Where(e => e.SupplyDate >= dateFrom.Value);
                }

                if (dateTo.HasValue)
                {
                    query = query.Where(e => e.SupplyDate <= dateTo.Value);
                }

                if (fuelId.HasValue)
                {
                    query = query.Where(e => e.FuelSupplyFuels.Any(f => f.FuelId == fuelId.Value));
                }

                if (supplierId.HasValue)
                {
                    query = query.Where(e => e.SupplierId == supplierId.Value);
                }

                if (sellerId.HasValue)
                {
                    query = query.Where(e => e.SellerId == sellerId.Value);
                }

                var supplies = query.OrderByDescending(e => e.SupplyDate).ToList();
                _logger.LogInformation("Получено {Count} записей поставок ГСМ", supplies.Count);
                return supplies;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении поставок ГСМ");
                throw;
            }
        }

        public void CreateFuelSupply(FuelSupply fuelSupply)
        {
            _logger.LogInformation("Добавление поставки ГСМ {@FuelSupply}", fuelSupply);
            try
            {
                using var transaction = _context.Database.BeginTransaction();
                _context.FuelSupplies.Add(fuelSupply);
                _context.SaveChanges();
                transaction.Commit();

                _logger.LogInformation(
                    "Поставка ГСМ добавлена, Id={FuelSupplyId}, позиций={PositionCount}",
                    fuelSupply.Id,
                    fuelSupply.FuelSupplyFuels.Count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении поставки ГСМ {@FuelSupply}", fuelSupply);
                throw;
            }
        }

        public void DeleteFuelSupply(int id)
        {
            _logger.LogInformation("Удаление поставки ГСМ Id={FuelSupplyId}", id);
            try
            {
                var fuelSupply = _context.FuelSupplies
                    .Include(e => e.FuelSupplyFuels)
                    .FirstOrDefault(e => e.Id == id);

                if (fuelSupply == null)
                {
                    throw new InvalidOperationException($"Поставка ГСМ с идентификатором {id} не найдена");
                }

                _context.FuelSupplies.Remove(fuelSupply);
                _context.SaveChanges();
                _logger.LogInformation("Поставка ГСМ удалена, Id={FuelSupplyId}", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении поставки ГСМ Id={FuelSupplyId}", id);
                throw;
            }
        }
    }
}
