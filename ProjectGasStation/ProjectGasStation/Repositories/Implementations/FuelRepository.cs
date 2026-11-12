using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Data;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class FuelRepository : IFuelRepository
    {
        private readonly DataContext _context;

        private readonly ILogger<FuelRepository> _logger;

        public FuelRepository(DataContext context, ILogger<FuelRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Fuel> ReadFuels()
        {
            _logger.LogDebug("Получение списка ГСМ");
            try
            {
                var fuels = _context.Fuels.AsNoTracking().OrderBy(e => e.Name).ToList();
                _logger.LogInformation("Получено {Count} записей ГСМ", fuels.Count);
                return fuels;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении списка ГСМ");
                throw;
            }
        }

        public Fuel ReadFuelById(int id)
        {
            _logger.LogDebug("Получение ГСМ по Id={FuelId}", id);
            try
            {
                var fuel = _context.Fuels.AsNoTracking().FirstOrDefault(e => e.Id == id);
                if (fuel == null)
                {
                    _logger.LogWarning("ГСМ с Id={FuelId} не найден", id);
                    return null!;
                }

                _logger.LogInformation("Получен ГСМ Id={FuelId}, наименование={FuelName}", fuel.Id, fuel.Name);
                return fuel;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении ГСМ по Id={FuelId}", id);
                throw;
            }
        }

        public void CreateFuel(Fuel fuel)
        {
            _logger.LogInformation("Добавление ГСМ {@Fuel}", fuel);
            try
            {
                _context.Fuels.Add(fuel);
                _context.SaveChanges();
                _logger.LogInformation("ГСМ добавлен, Id={FuelId}", fuel.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении ГСМ {@Fuel}", fuel);
                throw;
            }
        }

        public void UpdateFuel(Fuel fuel)
        {
            _logger.LogInformation("Изменение ГСМ {@Fuel}", fuel);
            try
            {
                _context.Fuels.Update(fuel);
                _context.SaveChanges();
                _logger.LogInformation("ГСМ изменён, Id={FuelId}", fuel.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при изменении ГСМ {@Fuel}", fuel);
                throw;
            }
        }

        public void DeleteFuel(int id)
        {
            _logger.LogInformation("Удаление ГСМ Id={FuelId}", id);
            try
            {
                var fuel = _context.Fuels.Find(id);
                if (fuel == null)
                {
                    throw new InvalidOperationException($"ГСМ с идентификатором {id} не найден");
                }

                _context.Fuels.Remove(fuel);
                _context.SaveChanges();
                _logger.LogInformation("ГСМ удалён, Id={FuelId}", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении ГСМ Id={FuelId}", id);
                throw;
            }
        }
    }
}
