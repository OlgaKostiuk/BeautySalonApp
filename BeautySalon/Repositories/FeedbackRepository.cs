using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeautySalon.Models;
using BeautySalon.Models.Feedbacks;

namespace BeautySalon.Repositories
{
    public class FeedbackRepository : BaseRepository, ICrud<Feedback>
    {
        public FeedbackRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Feedback Create(Feedback model)
        {
            _context.Feedbacks.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Feedback GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Feedback Update(Feedback model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feedback> GetAll()
        {
            return _context.Feedbacks.Where(x => !x.IsDeleted && x.IsApproved).ToList();
        }
    }
}