// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBcontext" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel;
using FundooModel.Model.CollaboratorModel;
using FundooModel.Model.LabelModel;
using FundooModel.Model.NotesModel;
using FundooModel.UserModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepo.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class UserContext : DbContext
    {
        /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<UserModel> UserDetail { get; set; }
        public DbSet<LabelModel> Label { get; set; }
        public DbSet<NotesModel> NotesDetails { get; set; }
        public DbSet<CollaboratorModel> collaboratorDetails { get; set; }

       
    }
}
