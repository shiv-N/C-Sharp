using BusinessManager;
using Common;
using FundooRepository.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundooTest.UserAccount
{
   public class AccountTesting
    {  
        [Fact]
        public void AccountRegistration()
        {
            var repository = new Mock<IAccountRepository>();
            var business = new Account(repository.Object);

            var model = new FundooModels()
            {
                Id = 5,
                FirstName = "shiv",
                LastName = "charan",
                PhoneNumber = "6423894630",
                Email = "abc@gmail.com",
                Password = "abc@123",
                UserAddress = "mumbai",
                Token = "redrtd"
                
            };

            var data = business.Register(model);

            Assert.NotNull(data);
        }
    }
}
