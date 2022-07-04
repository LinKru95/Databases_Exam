using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DbRepository
    {
        private readonly StudentsDbContext _dbContext;
        public DbRepository()
        {
            _dbContext = new StudentsDbContext();
        }
    }
}
