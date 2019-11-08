// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorTesting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.Model.CollaboratorModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Xunit;

namespace FundooTesting
{
    /// <summary>
    /// 
    /// </summary>
    public class CollaboratorTesting
    {
        [Fact]

        public void AddCollaborator()
        {
            var service = new Mock<ICollaborator>();
            var controller = new CollaboratorController(service.Object);
            var Add = new CollaboratorModel()
            {
                Id = 2,
                Noteid = 9,
                Sendemail = "kavyakushi67@gmail.com",
                Receiveremail ="kavyacr44@gmail.com"
            };
            var data = controller.Add(Add);
            Assert.NotNull(data);
        }

    }
}
