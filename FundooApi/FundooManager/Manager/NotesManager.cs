// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotes" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.Model.NotesModel;
using FundooRepo.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FundooManager.Interface.INotes" />
    public class NotesManager : INotes
    {
        /// <summary>
        /// The notes repository
        /// </summary>
        private readonly INotesRepository notesRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        /// <param name="notesRepository">The notes repository.</param>
        public NotesManager(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }
        public async Task<string> Add(NotesModel notesModel)
        {
            try
            {
                await this.notesRepository.AddNotes(notesModel);
                return "Added Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Update(NotesModel notesModel)
        {
            try
            {
                await this.notesRepository.UpdateNotes(notesModel);
                return "Updated Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Delete(int Id)
        {
            try
            {
                await this.notesRepository.DeleteNotes(Id);
                return "Deleted Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<NotesModel> List(string Email)
        {
            try
            {
                var result = this.notesRepository.List(Email);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Archieve(int Id)
        {
            try
            {
                await this.notesRepository.Archieve(Id);
                return "Archieve Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> UnArchieve(int Id)
        {
            try
            {
                await this.notesRepository.UnArchive(Id);
                return "UnArchieve Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<NotesModel> ArchieveList(string Email)
        {
            var result = notesRepository.ArchieveList(Email);
            return result;
        }

        public async Task<string> Pin(int Id)
        {
            try
            {
                await this.notesRepository.Pin(Id);
                return "Pin Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> UnPin(int Id)
        {
            try
            {
                await this.notesRepository.UnPin(Id);
                return "UnPin Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Trash(int Id)
        {
            try
            {
                await this.notesRepository.Trash(Id);
                return "Trash Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public  string ImageUpload(int Id, IFormFile formFile)
        {
            try
            {
                 this.notesRepository.ImageUpload(Id, formFile);
                return "Image uploaded Succcessfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}

