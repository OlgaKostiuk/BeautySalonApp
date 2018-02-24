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
            return promotion;
        }

        public Promotion Update(Promotion model)
        {
            Promotion original = _context.Promotion.FirstOrDefault(x => x.Id == model.Id && x.IsDeleted == false);
            if (original == null)
                return null;
            model.Date = original.Date;

            _context.Entry(original).CurrentValues.SetValues(model);
            //original.Images.ForEach(x => x.IsDeleted = true);
            model.Images.ForEach(x => original.Images.Add(x));
            _context.SaveChanges();
            return original;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PageViewModel<Promotion> GetPage(int page, int size = 5)
        {
            var allData = _context.Promotion.OrderByDescending(x => x.Date).Where(x => !x.IsDeleted);
            List<Promotion> data = allData.Skip((page - 1) * size).Take(size).ToList();
            int count = allData.Count() % size == 0 ? allData.Count() / size : allData.Count() / size + 1;
            return new PageViewModel<Promotion>()
            {
                Data = data,
                Count = count
            };
        }
    }
}