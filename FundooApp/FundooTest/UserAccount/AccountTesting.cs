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

            var modelRegister = new FundooModels()
            {
              
                FirstName = "shiv",
                LastName = "charan",
                PhoneNumber = "6423894630",
                Email = "abc@gmail.com",
                Password = "abc@123",
                UserAddress = "mumbai",
                Token = "redrtd"
                
            };
            
            var dataRegister = business.RegisterAsync(modelRegister);
            Assert.NotNull(dataRegister);
        }

        [Fact]
        public void AccountLogin()
        {
            var repository = new Mock<IAccountRepository>();
            var business = new Account(repository.Object);

            var modelLogin = new FundooModels()
            {
                Email = "shiva@Gmail.com",
                Password = "QWERTY@123"
            };
            var dataLogin = business.Login(modelLogin);
            Assert.NotNull(dataLogin);
        }
    }
}
