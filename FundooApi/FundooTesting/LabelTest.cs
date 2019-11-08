// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelTesting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooApi.Controllers;
using FundooManager.Interface;
using FundooModel.Model.LabelModel;
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
    public class LabelTest
    {
        /// <summary>
        /// Addlabels this instance.
        /// </summary>
        [Fact]

        public void Addlabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var Add = new LabelModel()
            {
                Email = "kavyakushi67@gmail.com",
                Id = 3,
                Label = "888"
            };
            var data = controller.Add(Add);
            Assert.NotNull(data);
        }

        [Fact]

        public void Updatelabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var Add = new LabelModel()
            {
                Email = "kavyakushi67@gmail.com",
                Id = 3,
                Label = "888"
            };
          //  var data = controller.Delete(Update);
           // Assert.NotNull(data);
        }


        [Fact]

        public void Deletelabel()
        {
            var service = new Mock<ILabel>();
            var controller = new LabelController(service.Object);
            var Add = new LabelModel()
            {
                Email = "kavyakushi67@gmail.com",
                Id = 3,
                Label = "888"
            };

           // var data = controller.Delete(Delete);
           // Assert.NotNull(data);
        }


    }
}
