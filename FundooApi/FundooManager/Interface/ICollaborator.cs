// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICollaborator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.CollaboratorModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICollaborator
    {
        /// <summary>
        /// Adds the specified collaborator model.
        /// </summary>
        /// <param name="collaboratorModel">The collaborator model.</param>
        /// <returns></returns>
        string Add(CollaboratorModel collaboratorModel);
        /// <summary>
        /// Updates the specified collaborator model.
        /// </summary>
        /// <param name="collaboratorModel">The collaborator model.</param>
        /// <returns></returns>
        Task<string> Update(CollaboratorModel collaboratorModel);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task<string> Delete(int Id);
        /// <summary>
        /// Lists the specified sendemail.
        /// </summary>
        /// <param name="Sendemail">The sendemail.</param>
        /// <returns></returns>
        List<CollaboratorModel> List(string Sendemail);
        
    }
}
