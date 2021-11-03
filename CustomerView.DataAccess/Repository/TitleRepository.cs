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
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        private readonly ApplicationDbContext _db;

        public TitleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Title title)
        {
            var DbObj = _db.Titles.FirstOrDefault(s => s.TitleID == title.TitleID);

            if (DbObj != null)
            {
                DbObj.Description = title.Description;

                _db.SaveChanges();
            }
        }
    }
}
