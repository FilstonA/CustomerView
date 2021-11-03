﻿using CustomerView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.DataAccess.Repository.Interfaces
{
    public interface IStatusRepository
    {
        void Update(Status status);
    }
}
