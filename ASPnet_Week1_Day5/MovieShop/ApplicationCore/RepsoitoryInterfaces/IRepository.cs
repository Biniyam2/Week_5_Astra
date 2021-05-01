using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepsoitoryInterfaces
{
    public interface IRepository<T> where T : class
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public int Insert(T type);
        public int Update(T type);
        public int Delete (T type);
        public int StoreProcedure(T item);
    }
}
