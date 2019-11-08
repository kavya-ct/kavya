// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotesRepository" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.NotesModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface INotesRepository
    { 
        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task AddNotes(NotesModel notesModel);
        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task UpdateNotes(NotesModel notesModel);
        /// <summary>
        /// Deletes the notes.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task DeleteNotes(int Id);
        /// <summary>
        /// Lists the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesModel> List(string Email);
        /// <summary>
        /// Archieves the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task Archieve(int Id);
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task UnArchive(int Id);
        /// <summary>
        /// Archieves the list.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesModel> ArchieveList(string Email);
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task Pin(int Id);
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task UnPin(int Id);
        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task Trash(int Id);
        /// <summary>
        /// Images the upload.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="formFile">The form file.</param>
        /// <returns></returns>
        string ImageUpload(int Id, IFormFile formFile);

        
    }
}
