// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesRepository" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using FundooModel.Model.NotesModel;
using FundooRepo.Context;
using FundooRepo.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FundooRepo.Interface.INotesRepository" />
    public class NotesRepository : INotesRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public NotesRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public Task AddNotes(NotesModel notesModel)
        {
            NotesModel notesModel1 = new NotesModel()
            {
                Email = notesModel.Email,
                Id = notesModel.Id,
                Title = notesModel.Title,
                Description = notesModel.Description,
                Image = notesModel.Image,
                Remainder = notesModel.Remainder,
                Colour = null,
                Archieve = notesModel.Archieve,
                Trash = notesModel.Trash,
                Pin = false,
                CreateDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };
            userContext.NotesDetails.Add(notesModel);
            return Task.Run(() => userContext.SaveChanges());
        }

        public Task UpdateNotes(NotesModel notesModel)
        {
            NotesModel notesModel1 = new NotesModel();
            NotesModel note = userContext.NotesDetails.Where(p => p.Id == notesModel.Id).FirstOrDefault();
            if (note != null)
            {
                note.Email = notesModel.Email;
                note.Title = notesModel.Title;
                note.Description = notesModel.Description;
                note.Colour = notesModel.Colour;
                note.CreateDate = notesModel.CreateDate;
                note.Archieve = notesModel.Archieve;
                note.Remainder = notesModel.Remainder;
                userContext.NotesDetails.Update(note);
            }
            return Task.Run(() => userContext.SaveChanges());
        }

        public Task DeleteNotes(int Id)
        {
            NotesModel note = userContext.NotesDetails.Where(p => p.Id == Id).FirstOrDefault();
            if (note != null)
            {
                userContext.NotesDetails.Remove(note);
            }
            return Task.Run(() => userContext.SaveChanges());
        }

        public List<NotesModel> List(string Email)
        {
            bool note = userContext.NotesDetails.Any(p => p.Email == Email);
            if (note)
            {
                return userContext.NotesDetails.Where(p => p.Email == Email).ToList();
            }
            else
            {
                return null;
            }
        }

        public Task Archieve(int Id)
        {
            NotesModel result = userContext.NotesDetails.Where(p => p.Id == Id).SingleOrDefault();

            if (result != null)
            {
                result.Archieve = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }

        public Task UnArchive(int Id)
        {
            NotesModel note = userContext.NotesDetails.Where(i => i.Id == Id).SingleOrDefault();
            if (note != null)
            {
                note.Archieve = false;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }


        public List<NotesModel> ArchieveList(string Email)
        {
            bool note = userContext.NotesDetails.Any(p => p.Email == Email);
            if (note)
            {
                return userContext.NotesDetails.Where(p => p.Email == Email).ToList();
            }
            else
            {
                return null;
            }


        }

        public Task Pin(int Id)
        {
            NotesModel result = userContext.NotesDetails.Where(p => p.Id == Id).SingleOrDefault();

            if (result != null)
            {
                result.Pin = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }

        public Task UnPin(int Id)
        {
            NotesModel result = userContext.NotesDetails.Where(p => p.Id == Id).SingleOrDefault();

            if (result != null)
            {
                result.Pin = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;
        }

        public Task Trash(int Id)
        {
            NotesModel result = userContext.NotesDetails.Where(p => p.Id == Id).SingleOrDefault();

            if (result != null)
            {
                result.Trash = true;
                return Task.Run(() => userContext.SaveChanges());
            }
            return null;

        }

        public string ImageUpload(int Id, IFormFile formFile)
        {
            var path = formFile.OpenReadStream();
            var fileName = formFile.FileName;
            CloudinaryDotNet.Account cloudinary = new CloudinaryDotNet.Account("dxit9qqga", "165935727641643", "mSZjd6sUVQj6Z-2IumRAGeAjv3Y");
            CloudinaryDotNet.Cloudinary cloud = new CloudinaryDotNet.Cloudinary(cloudinary);
            var Uploadfile = new ImageUploadParams()
            {
                File = new FileDescription(fileName, path)
            };
            var data = cloud.Upload(Uploadfile);
            var result = userContext.NotesDetails.Where(i => i.Id == Id).SingleOrDefault();
            result.Image = data.Uri.ToString();
            userContext.SaveChanges();
            return result.Image;
        }
    
    }
   
    
}

