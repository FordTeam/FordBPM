using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Repository<T> : IRepository<T> where T : class
    {
        public void add(T entity)
        {
            throw new NotImplementedException();
        }

        public void delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> findAll(Func<T, bool> exp)
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
