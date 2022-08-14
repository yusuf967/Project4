using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    //class -- referece type
    public interface IRepositoryDal<T> where T : class,IEntity,new()
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}
