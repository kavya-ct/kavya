// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesModel" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FundooModel.Model.NotesModel
{
    /// <summary>
    /// 
    /// </summary>
    public class NotesModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        private int id;
        private string title;
        private string description;
        private string remainder;
        private string colour;
        private bool archive;
        private bool trash;
        private bool pin;
        private DateTime? createDate;
        private DateTime? modifiedDate;
        private string image;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [ForeignKey("userModel")]


        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Title
        {
            set { this.title = value; }
            get { return this.title; }
        }

        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }

        public string Image
        {
            set { this.image = value; }
            get { return this.image; }
        }

        public string Remainder
        {
            set { this.remainder = value; }
            get { return this.remainder; }
        }

        public string Colour
        {
            set { this.colour = value; }
            get { return this.colour; }
        }

        public bool Archieve
        {
            set { this.archive = value; }
            get { return this.archive; }
        }

        public bool Trash
        {
            set { this.trash = value; }
            get { return this.trash; }
        }

        public bool Pin
        {
            set { this.pin = value; }
            get { return this.pin; }
        }

        public DateTime? CreateDate
        {
            set { this.createDate = value; }
            get { return createDate; }
        }

        public DateTime? ModifiedDate
        {
            set { this.modifiedDate = value; }
            get { return modifiedDate; }
        }



    }
}
