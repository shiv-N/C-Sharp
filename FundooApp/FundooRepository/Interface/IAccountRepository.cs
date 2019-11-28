using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Interface
{
    public interface IAccountRepository
    {
        string Register(FundooModels model);

        public FundooModels Login(FundooModels model);
       //public IEnumerable<FundooModels> GetAllEmployee();
    }
}
