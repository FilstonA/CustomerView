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
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        private readonly ApplicationDbContext _db;

        public StatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Status status)
        {
            var DbObj = _db.Statuses.FirstOrDefault(s => s.StatusID == status.StatusID);

            if (DbObj != null)
            {
                DbObj.Description = status.Description;
                DbObj.IsMarketingAllowed = status.IsMarketingAllowed;

                _db.SaveChanges();
            }
        }
    }
}
