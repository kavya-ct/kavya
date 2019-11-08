// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResetPassword.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FundooModel.UserModels
{
    public class ResetPasswordModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The password
        /// </summary>
        private string password;
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        private string newPassword; 
        [ForeignKey("UserModel")]
        [EmailAddress]
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string NewPassword
        {
            set { this.newPassword = value; }
            get { return this.newPassword; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
