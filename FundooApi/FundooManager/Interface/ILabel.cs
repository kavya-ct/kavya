// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILabel" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILabel
    {
        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string Add(LabelModel labelModel);
        /// <summary>
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        Task<string> Update(LabelModel labelModel);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task<string> Delete(int Id);
        /// <summary>
        /// Lists the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<LabelModel> List(string Email);
    }
}
