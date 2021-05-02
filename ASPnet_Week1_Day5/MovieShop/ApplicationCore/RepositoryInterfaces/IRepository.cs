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
        public void Insert(T type);
        public void Update(T type);
        public void Delete (T type);
        public void StoreProcedure(T item);
    }
}
