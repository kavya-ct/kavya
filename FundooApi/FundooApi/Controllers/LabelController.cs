
//// --------------------------------------------------------------------------------------------------------------------
//// <copyright file="LabelController.cs" company="Bridgelabz">
////   Copyright © 2019 Company="BridgeLabz"
//// </copyright>
//// <creator name="kavya ct"/>
//// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.Model.LabelModel;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        /// <summary>
        /// The label
        /// </summary>
        private readonly ILabel label;
        public LabelController(ILabel label)
        {
            this.label = label;
        }
        [HttpPost]
        [Route("add")]
        public  IActionResult Add(LabelModel labelModel)
       {
            try
            {
                var result = this.label.Add(labelModel);
               return Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update(LabelModel labelModel)
        {
            try
            {
                var result = await label.Update(labelModel);
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
                var result = await label.Delete(Id);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("get")]

        public List <LabelModel> List(string Email)
        {
            var result = label.List(Email);
            return result;
        }


    }
}

