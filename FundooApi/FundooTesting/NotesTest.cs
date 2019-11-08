// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Notestesting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooApi.Controllers;
using FundooManager.Interface;
using FundooModel.Model.NotesModel;
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
    public class NotesTest
    {
        /// <summary>
        /// Adds the notes.
        /// </summary>
        [Fact]
        public void AddNotes()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var Add = new NotesModel()
            {
                Email = "kavyakushi67@gmail.com",
                Id = 3,
                Title = "555",
                Description = "vkv",
                Colour = "blue"
            };
            var data = controller.Add(Add);
            Assert.NotNull(data);
        }
    }

}
