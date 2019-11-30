using BusinessManager.Interface;
using Common;
using Common.Models;
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

        public FundooModels Login(FundooModels model)
        {
            if (model != null)
            {
                return account.Login(model);
            }
            else
            {
                return model;
            }
        }

        public string ForgotPassword(ForgotPassword model)
        {
            return account.ForgotPassword(model);
        }

        public string ResetPassword(ResetModel token)
        {
            return account.ResetPassword(token);
        }
    }
}
