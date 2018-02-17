using BeautySalon.Models;
using BeautySalon.Repositories;

namespace BeautySalon
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private static UnitOfWork _instance;

        public static UnitOfWork Instance => _instance ?? (_instance = new UnitOfWork());

        private UnitOfWork()
        {
            _context = ApplicationDbContext.Create();
        }

        private PromotionRepository _promotionRepository;

        private ServiceRepository _serviceRepository;

        public PromotionRepository PromotionRepository =>
            _promotionRepository ?? (_promotionRepository = new PromotionRepository(_context));

        public ServiceRepository ServiceRepository =>
            _serviceRepository ?? (_serviceRepository = new ServiceRepository(_context));
    }
}