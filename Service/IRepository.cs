using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IRepository<T> where T : class
    {
        void add(T entity);
        void delete(T entity);
        void save();
        IEnumerable<T> findAll(Func<T, bool> exp);
    }
}
