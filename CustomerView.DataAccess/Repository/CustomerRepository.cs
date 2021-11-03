using CustomerView.DataAccess.Data;
using CustomerView.DataAccess.Repository.Interfaces;
using CustomerView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.DataAccess.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Customer customer)
        {
            var DbObj = _db.Customers.FirstOrDefault(s => s.CustomerID == customer.CustomerID);

            if (DbObj != null)
            {
                DbObj.Forename = customer.Forename;
                DbObj.Surname = customer.Surname;
                DbObj.StatusID = customer.StatusID;
                DbObj.TitleID = customer.TitleID;
                DbObj.DateOfBirth = customer.DateOfBirth;
                DbObj.Email = customer.Email;

                _db.SaveChanges();
            }
        }
    }
}
