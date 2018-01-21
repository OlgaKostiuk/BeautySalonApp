using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Repositories
{
    internal interface ICrud<TModel>
    {
        TModel Create(TModel model);
        TModel GetById(int id);
        TModel Update(TModel model);
        void Delete(int id);
    }
}
