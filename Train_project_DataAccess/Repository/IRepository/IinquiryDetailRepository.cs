using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project_Models;

namespace Train_project_DataAccess.Repository.IRepository
{
    public interface IinquiryDetailRepository : IRepository<InquiryDetail>
    {
        void Update(InquiryDetail obj);
    }
}
