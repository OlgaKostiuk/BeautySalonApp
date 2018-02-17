using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeautySalon.Models;
using BeautySalon.Models.Services;

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
                new ServiceCategory { Title = "Стрижка и укладка" },
                new ServiceCategory { Title = "Окрашивание" },
                new ServiceCategory { Title = "Процедуры для волос" },
                new ServiceCategory { Title = "Визаж" },
                new ServiceCategory { Title = "Ногтевой сервис" },
                new ServiceCategory { Title = "Косметологические услуги" },
                new ServiceCategory { Title = "Массаж" },
                new ServiceCategory { Title = "Мужской салон красоты" }
            });
        }
    }
}