// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForgetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModel.UserModels
{
    /// <summary>
    /// 
    /// </summary>
    public class ForgetPasswordModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        private string password;
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        public string NewPassword
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}