﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesController" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using Abp.UI;
using FundooManager.Interface;
using FundooModel.Model.NotesModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        /// <summary>
        /// The label
        /// </summary>
        private readonly INotes notes;
        public NotesController(INotes notes)
        {
            this.notes = notes;
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(NotesModel notesModel)
        {
            try
            {
                var result = await notes.Add(notesModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(NotesModel notesModel)
        {
            try
            {
                var result = await notes.Update(notesModel);
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
                var result = await notes.Delete(Id);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("list")]
        public List<NotesModel> List(string Email)
        {
            {
                var result = this.notes.List(Email);
                return result;
            }
        }
        [HttpPut]
        [Route("archieve")]
        public async Task<IActionResult> Archieve(int Id)
        {
            try
            {
                var result = await notes.Archieve(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("unarchieve")]
        public async Task<IActionResult> UnArchieve(int Id)
        {
            try
            {
                var result = await notes.UnArchieve(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("archievelist")]
        public List<NotesModel> ArchieveList(string Email)
        {
            {
                var result = this.notes.ArchieveList(Email);
                return result;
            }
        }

        [HttpPost]
        [Route("pin")]
        public async Task<IActionResult> Pin(int Id)
        {
            try
            {
                var result = await notes.Pin(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("unpin")]
        public async Task<IActionResult> UnPin(int Id)
        {
            try
            {
                var result = await notes.UnPin(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("trash")]

        public async Task<IActionResult> Trash(int Id)
        {
            try
            {
                var result = await notes.Trash(Id);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("image")]

        public IActionResult ImageUpload(int Id, IFormFile formFile)
        {
            try
            {
                var result =  notes.ImageUpload(Id,formFile);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}




   








