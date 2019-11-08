// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Applicationsetting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModel.Model.UserModels
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationSetting
    {
        /// <summary>
        /// Gets or sets the JWT secret.
        /// </summary>
        /// <value>
        /// The JWT secret.
        /// </value>
        public string JWT_Secret { get; set; }
    }
}
