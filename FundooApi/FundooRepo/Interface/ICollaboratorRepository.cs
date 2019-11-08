// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Icollaborator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.CollaboratorModel;
using FundooModel.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICollaboratorRepository
    {
        /// <summary>
        /// Addcollaborators the specified collaborator model.
        /// </summary>
        /// <param name="collaboratorModel">The collaborator model.</param>
        /// <returns></returns>
        string Addcollaborator(CollaboratorModel collaboratorModel);
        /// <summary>
        /// Updatecollaborators the specified collaborator model.
        /// </summary>
        /// <param name="collaboratorModel">The collaborator model.</param>
        /// <returns></returns>
        Task Updatecollaborator(CollaboratorModel collaboratorModel);
        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task DeleteCollaborator(int Id);
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        List<CollaboratorModel> GetList();
        /// <summary>
        /// Listofs the collaborator.
        /// </summary>
        /// <param name="Sendemail">The sendemail.</param>
        /// <returns></returns>
        List<CollaboratorModel> ListofCollaborator(string Sendemail);
    }
}
