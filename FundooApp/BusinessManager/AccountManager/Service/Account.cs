using BusinessManager.Interface;
using Common;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;


namespace BusinessManager
{
    public class Account : IAccount
    {
        IAccountRepository account;
        public Account(IAccountRepository account)
        {
            this.account = account;
        }
        public string Register(FundooModels model)
        {
            if(model != null)
            {
                return this.account.Register(model);
            }
            else
            {
                return "Insufficients details....";
            }
        }
    }
}
