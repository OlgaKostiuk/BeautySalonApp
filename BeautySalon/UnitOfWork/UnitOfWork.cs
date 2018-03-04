using BeautySalon.Controllers;
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

        private FeedbackRepository _feedbackRepository;

        private OrderRepository _orderRepository;

        public PromotionRepository PromotionRepository =>
            _promotionRepository ?? (_promotionRepository = new PromotionRepository(_context));

        public ServiceRepository ServiceRepository =>
            _serviceRepository ?? (_serviceRepository = new ServiceRepository(_context));

        public FeedbackRepository FeedbackRepository =>
            _feedbackRepository ?? (_feedbackRepository = new FeedbackRepository(_context));

        public OrderRepository OrderRepository =>
            _orderRepository ?? (_orderRepository = new OrderRepository(_context));
    }
}