using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Interface
{
    public interface IAccount
    {
        string Register(FundooModels model);
        public FundooModels Login(FundooModels model);
        //public IEnumerable<FundooModels> GetAllEmployee();
    }
}
