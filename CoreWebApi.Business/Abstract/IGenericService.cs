using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Business.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int? id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
