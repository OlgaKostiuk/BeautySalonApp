using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using BeautySalon.Models;
using BeautySalon.Models.Promotions;

namespace BeautySalon.Repositories
{
    public class PromotionRepository : BaseRepository, ICrud<Promotion>
    {
        public PromotionRepository(ApplicationDbContext context) : base(context)
        {
        }



        public Promotion Create(Promotion model)
        {
            _context.Promotion.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Promotion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Promotion Update(Promotion model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}