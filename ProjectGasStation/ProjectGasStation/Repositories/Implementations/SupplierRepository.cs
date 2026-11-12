using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Data;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class SupplierRepository : ISupplierRepository
    {
        private readonly DataContext _context;

        private readonly ILogger<SupplierRepository> _logger;

        public SupplierRepository(DataContext context, ILogger<SupplierRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Supplier> ReadSuppliers()
        {
            _logger.LogDebug("Получение списка поставщиков");
            try
            {
                var suppliers = _context.Suppliers.AsNoTracking().OrderBy(e => e.CompanyName).ToList();
                _logger.LogInformation("Получено {Count} записей поставщиков", suppliers.Count);
                return suppliers;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении списка поставщиков");
                throw;
            }
        }

        public Supplier ReadSupplierById(int id)
        {
            _logger.LogDebug("Получение поставщика по Id={SupplierId}", id);
            try
            {
                var supplier = _context.Suppliers.AsNoTracking().FirstOrDefault(e => e.Id == id);
                if (supplier == null)
                {
                    _logger.LogWarning("Поставщик с Id={SupplierId} не найден", id);
                    return null!;
                }

                _logger.LogInformation("Получен поставщик Id={SupplierId}, наименование={CompanyName}", supplier.Id, supplier.CompanyName);
                return supplier;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении поставщика по Id={SupplierId}", id);
                throw;
            }
        }

        public void CreateSupplier(Supplier supplier)
        {
            _logger.LogInformation("Добавление поставщика {@Supplier}", supplier);
            try
            {
                _context.Suppliers.Add(supplier);
                _context.SaveChanges();
                _logger.LogInformation("Поставщик добавлен, Id={SupplierId}", supplier.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении поставщика {@Supplier}", supplier);
                throw;
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _logger.LogInformation("Изменение поставщика {@Supplier}", supplier);
            try
            {
                _context.Suppliers.Update(supplier);
                _context.SaveChanges();
                _logger.LogInformation("Поставщик изменён, Id={SupplierId}", supplier.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при изменении поставщика {@Supplier}", supplier);
                throw;
            }
        }

        public void DeleteSupplier(int id)
        {
            _logger.LogInformation("Удаление поставщика Id={SupplierId}", id);
            try
            {
                var supplier = _context.Suppliers.Find(id);
                if (supplier == null)
                {
                    throw new InvalidOperationException($"Поставщик с идентификатором {id} не найден");
                }

                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
                _logger.LogInformation("Поставщик удалён, Id={SupplierId}", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении поставщика Id={SupplierId}", id);
                throw;
            }
        }
    }
}
