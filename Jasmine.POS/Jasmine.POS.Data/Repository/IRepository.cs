using Jasmine.POS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasmine.POS.Data.Repository
{    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        T GetById(int Id);
        OperationStatus Save(T model);
        OperationStatus Delete(int Id);

    }
}
