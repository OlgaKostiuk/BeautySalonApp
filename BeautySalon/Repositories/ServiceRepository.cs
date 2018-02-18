using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeautySalon.Models;
using BeautySalon.Models.Services;
using Microsoft.Build.Framework.XamlTypes;

namespace BeautySalon.Repositories
{
    public class ServiceRepository : BaseRepository, ICrud<Service>
    {
        public ServiceRepository(ApplicationDbContext context) : base(context)
        {
                
        }

        public Service Create(Service model)
        {
            throw new NotImplementedException();
        }

        public Service GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Service Update(Service model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            _context.ServiceCategories.AddRange(new[] {
                new ServiceCategory { Title = "Стрижка и укладка", GenderAffiliation = GenderAffiliation.ForWomen },
                new ServiceCategory { Title = "Окрашивание", GenderAffiliation = GenderAffiliation.ForWomen },
                new ServiceCategory { Title = "Процедуры для волос", GenderAffiliation = GenderAffiliation.ForWomen },
                new ServiceCategory { Title = "Визаж", GenderAffiliation = GenderAffiliation.ForWomen },
                new ServiceCategory { Title = "Ногтевой сервис", GenderAffiliation = GenderAffiliation.ForWomen },
                new ServiceCategory { Title = "Косметологические услуги", GenderAffiliation = GenderAffiliation.ForWomen },
                new ServiceCategory { Title = "Массаж", GenderAffiliation = GenderAffiliation.ForWomen },

                new ServiceCategory { Title = "Парикмахерские услуги", GenderAffiliation = GenderAffiliation.ForMen },
                new ServiceCategory { Title = "Окрашивание", GenderAffiliation = GenderAffiliation.ForMen },
                new ServiceCategory { Title = "Ногтевой сервис", GenderAffiliation = GenderAffiliation.ForMen },
                new ServiceCategory { Title = "Косметологические услуги", GenderAffiliation = GenderAffiliation.ForMen },
                new ServiceCategory { Title = "Массаж", GenderAffiliation = GenderAffiliation.ForMen }
            });
            _context.SaveChanges();
        }

        public List<ServiceCategory> GetAll()
        {
            return _context.ServiceCategories.ToList();
        }
    }
}