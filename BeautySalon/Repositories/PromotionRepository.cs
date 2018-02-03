using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using BeautySalon.Models;
using BeautySalon.Models.Promotions;
using WebGrease.Css.Extensions;

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
            Promotion promotion = _context.Promotion.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
            if(promotion != null)
                promotion.Images = promotion.Images.Where(x => x.IsDeleted == false).ToList();
            return promotion;
        }

        public Promotion Update(Promotion model)
        {
            Promotion original = _context.Promotion.FirstOrDefault(x => x.Id == model.Id && x.IsDeleted == false);
            if (original == null)
                return null;
            model.Date = original.Date;

            original.Images.ForEach(x => x.IsDeleted = true);
            _context.SaveChanges();
            model.Images.ForEach(x =>
            {
                original.Images.Add(new PromotionImage {Path = x.Path});
            });
            _context.SaveChanges();
            _context.Entry(original).CurrentValues.SetValues(model);
            _context.SaveChanges();
            return original;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}