// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountTesting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooApi.Controllers;
using FundooManager.Interface;
using FundooModel.UserModels;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundooTesting
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountTest
    {
        /// <summary>
        /// Registrations this instance.
        /// </summary>
        [Fact]

        public void Registration()
        {
            var service = new Mock<IAccountManager>();
            //var controller = new AccountController(service.Object);
            var Add = new UserModel()
            {
                FirstName = "kavya",
                LastName = "kushi",
                Email = "kavyakushi67@gmail.com",
                Password = "555"
            };
           //var data = controller.Registration(Add);
            //Assert.NotNull(data);
        }

        [Fact]
        public void Login()
        {
            var service = new Mock<IAccountManager>();
           // var controller = new AccountController(service.Object);
            var Add = new UserModel()
            {
                Email = "kavyakushi67@gmail.com",
                Password = "777"


            };
            //var data = controller.Registration(Add);
            //Assert.NotNull(data);
        }
    }
}
