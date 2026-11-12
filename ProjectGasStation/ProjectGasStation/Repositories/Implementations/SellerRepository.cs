using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Data;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations
{
    internal class SellerRepository : ISellerRepository
    {
        private readonly DataContext _context;

        private readonly ILogger<SellerRepository> _logger;

        public SellerRepository(DataContext context, ILogger<SellerRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Seller> ReadSellers()
        {
            _logger.LogDebug("Получение списка продавцов");
            try
            {
                var sellers = _context.Sellers.AsNoTracking().OrderBy(e => e.LastName).ThenBy(e => e.FirstName).ToList();
                _logger.LogInformation("Получено {Count} записей продавцов", sellers.Count);
                return sellers;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении списка продавцов");
                throw;
            }
        }

        public Seller ReadSellerById(int id)
        {
            _logger.LogDebug("Получение продавца по Id={SellerId}", id);
            try
            {
                var seller = _context.Sellers.AsNoTracking().FirstOrDefault(e => e.Id == id);
                if (seller == null)
                {
                    _logger.LogWarning("Продавец с Id={SellerId} не найден", id);
                    return null!;
                }

                _logger.LogInformation("Получен продавец Id={SellerId}, ФИО={LastName} {FirstName}", seller.Id, seller.LastName, seller.FirstName);
                return seller;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении продавца по Id={SellerId}", id);
                throw;
            }
        }

        public void CreateSeller(Seller seller)
        {
            _logger.LogInformation("Добавление продавца {@Seller}", seller);
            try
            {
                _context.Sellers.Add(seller);
                _context.SaveChanges();
                _logger.LogInformation("Продавец добавлен, Id={SellerId}", seller.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении продавца {@Seller}", seller);
                throw;
            }
        }

        public void UpdateSeller(Seller seller)
        {
            _logger.LogInformation("Изменение продавца {@Seller}", seller);
            try
            {
                _context.Sellers.Update(seller);
                _context.SaveChanges();
                _logger.LogInformation("Продавец изменён, Id={SellerId}", seller.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при изменении продавца {@Seller}", seller);
                throw;
            }
        }

        public void DeleteSeller(int id)
        {
            _logger.LogInformation("Удаление продавца Id={SellerId}", id);
            try
            {
                var seller = _context.Sellers.Find(id);
                if (seller == null)
                {
                    throw new InvalidOperationException($"Продавец с идентификатором {id} не найден");
                }

                _context.Sellers.Remove(seller);
                _context.SaveChanges();
                _logger.LogInformation("Продавец удалён, Id={SellerId}", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении продавца Id={SellerId}", id);
                throw;
            }
        }
    }
}
