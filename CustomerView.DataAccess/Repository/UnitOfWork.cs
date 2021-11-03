using CustomerView.DataAccess.Data;
using CustomerView.DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Customer = new CustomerRepository(_db);
            Status = new StatusRepository(_db);
            Title = new TitleRepository(_db);
            StoredProcs = new StoredProcs(_db);
        }

        public ICustomerRepository Customer { get; private set; }
        public IStatusRepository Status { get; private set; }
        public ITitleRepository Title { get; private set; }
        public IStoredProcs StoredProcs { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
