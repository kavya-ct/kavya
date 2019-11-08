// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotes" company="Bridgelabz">
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

namespace FundooManager.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface INotes
    {
        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task<string> Add(NotesModel notesModel);
        Task<string> Update(NotesModel notesModel);
        Task<string> Delete(int Id);
        List<NotesModel> List(string Email);
        Task<string> Archieve(int Id);
        Task<string> UnArchieve(int Id);
        List<NotesModel> ArchieveList(string Email);
        Task<string> Pin(int Id);
        Task<string> UnPin(int Id);
        Task<string> Trash(int id);
        string ImageUpload(int Id, IFormFile formFile);
        
    }
}
