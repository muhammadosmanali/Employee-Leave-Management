using Employee_Leave_Management.Contract;
using Employee_Leave_Management.Data;
using Employee_Leave_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveHistory FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
