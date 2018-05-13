using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public class EmployeeRepository : IRepository
    {
        private AdventureWorks2014Entities _context;

        public EmployeeRepository()
        {
            _context = new AdventureWorks2014Entities();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return _context.Set<T>();
        }

    }
}
