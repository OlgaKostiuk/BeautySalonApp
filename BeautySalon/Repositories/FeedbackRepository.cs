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
            Feedback feedback = _context.Feedbacks.FirstOrDefault(x => x.Id == id);

            if (feedback == null) return;

            feedback.IsDeleted = true;
            _context.SaveChanges();
        }

        public void Approve(int id)
        {
            Feedback feedback = _context.Feedbacks.FirstOrDefault(x => x.Id == id);

            if (feedback == null) return;

            feedback.IsApproved = true;
            _context.SaveChanges();
        }

        public List<Feedback> GetAllApproved()
        {
            return _context.Feedbacks.Where(x => !x.IsDeleted && x.IsApproved).ToList();
        }
        public List<Feedback> GetAll()
        {
            return _context.Feedbacks.Where(x => !x.IsDeleted).OrderBy(x => x.IsApproved ? 1 : 0).ToList();
        }
    }
}