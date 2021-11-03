using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.DataAccess.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customer { get; }
        IStatusRepository Status { get; }
        ITitleRepository Title { get; }
        IStoredProcs StoredProcs { get; }
    }
}
