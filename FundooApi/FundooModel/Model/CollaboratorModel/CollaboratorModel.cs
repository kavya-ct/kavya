// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModel.Model.CollaboratorModel
{
    /// <summary>
    /// 
    /// </summary>
    public class CollaboratorModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The noteid
        /// </summary>
        private int noteid;
        /// <summary>
        /// The sendemail
        /// </summary>
        private string sendemail;
        /// <summary>
        /// The receiveremail
        /// </summary>
        private string receiveremail;

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

        public int Noteid
        {
            set { this.noteid = value; }
            get { return this.noteid; }
        }

        public string Sendemail
        {
            set { this.sendemail = value; }
            get { return this.sendemail; }

        }

        public string Receiveremail
        {
            set { this.receiveremail = value; }
            get { return this.receiveremail; }
        }
    }
}
