using Common;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Interface
{
    public interface IAccountRepository
    {
        string Register(FundooModels model);

        public FundooModels Login(FundooModels model);
        public IEnumerable<FundooModels> GetAllEmployee();
        public string ForgotPassword(ForgotPassword model);
    }
}
