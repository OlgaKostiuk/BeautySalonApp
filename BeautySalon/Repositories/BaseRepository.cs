using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeautySalon.Models;

namespace BeautySalon.Repositories
{
    public class BaseRepository
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}