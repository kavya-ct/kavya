// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.Model.CollaboratorModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
        public class CollaboratorController : ControllerBase
        {
            /// <summary>
            /// The label
            /// </summary>
            private readonly ICollaborator collaborator;
            /// <summary>
           /// Initializes a new instance of the <see cref="CollaboratorController"/> class.
          /// </summary>
         /// <param name="collaborator">The collaborator.</param>
        public CollaboratorController(ICollaborator collaborator)
            {
                this.collaborator = collaborator;
            }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(CollaboratorModel collaboratorModel)
        {
            try
            {
                string email = User.Claims.First(c => c.Type == "Email").Value;
                var result = this. collaborator.Add(collaboratorModel);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update(CollaboratorModel collaboratorModel)
        {
            try
            {
                string email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await collaborator.Update(collaboratorModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("delete")]

        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                string email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await collaborator.Delete(Id);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("get")]

        public List<CollaboratorModel> List(string Sendemail)
        {
            string sendemail = User.Claims.First(c => c.Type == "Sendemail").Value;
            var result = collaborator.List(Sendemail);
            return result;
        }

    }

       
    }


