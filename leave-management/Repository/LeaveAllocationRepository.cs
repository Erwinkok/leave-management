﻿using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _db.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
