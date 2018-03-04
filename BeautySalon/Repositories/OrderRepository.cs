using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeautySalon.Models;
using BeautySalon.Models.Orders;

namespace BeautySalon.Repositories
{
    public class OrderRepository : BaseRepository, ICrud<CallbackOrder>
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public CallbackOrder Create(CallbackOrder model)
        {
            _context.CallbackOrders.Add(model);
            _context.SaveChanges();
            return model;
        }

        public CallbackOrder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CallbackOrder Update(CallbackOrder model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            CallbackOrder feedback = _context.CallbackOrders.FirstOrDefault(x => x.Id == id);

            if (feedback == null) return;

            feedback.IsPending = false;
            _context.SaveChanges();
        }

        public List<CallbackOrder> GetAllCallbackOrders()
        {
            return _context.CallbackOrders.Where(x => x.IsPending).OrderBy(x => x.DateTime).ToList();
        }
    }
}