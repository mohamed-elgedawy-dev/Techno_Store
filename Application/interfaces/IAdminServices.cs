using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Application.interfaces
{
    internal interface IAdminServices<T>
    {


        T Add(T dto);
        List<T> GetAll();
        T GetById(int id);
        void Update(T dto);
        void Delete(int id);






    }
}
