using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project_DataAccess.Data;
using Train_project_DataAccess.Repository.IRepository;
using Train_project_Models;

namespace Train_project_DataAccess.Repository
{
    public class InquiryHeaderRepository : Repository<InquiryHeader>, IinquiryHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public InquiryHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(InquiryHeader obj)
        {
            _db.InquiryHeader.Update(obj);
        }
    }
}
