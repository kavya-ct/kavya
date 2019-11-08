// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.Model.CollaboratorModel;
using FundooRepo.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FundooManager.Interface.ICollaborator" />
    public class CollaboratorManager:ICollaborator
    {
        /// <summary>
        /// The collaborator repository
        /// </summary>
        private readonly ICollaboratorRepository collaboratorRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorManager"/> class.
        /// </summary>
        /// <param name="collaboratorRepository">The collaborator repository.</param>
        public CollaboratorManager(ICollaboratorRepository collaboratorRepository)
        {
            
            this.collaboratorRepository = collaboratorRepository;
        }

        public string Add(CollaboratorModel collaboratorModel)
        {

            this.collaboratorRepository.Addcollaborator(collaboratorModel);
            return "COLLABORATOR ADDED Successfully";


        }

        public async Task<string> Update(CollaboratorModel collaboratorModel)
        {
            try
            {
                await this.collaboratorRepository.Updatecollaborator(collaboratorModel);
                return " COLLABORATOR UPDATE Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Delete(int Id)
        {
            try
            {
                await this.collaboratorRepository.DeleteCollaborator(Id);
                return "COLLABORATOR Delete Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CollaboratorModel> List(string Sendemail)
        {
            try
            {
                var result = this.collaboratorRepository.ListofCollaborator(Sendemail);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
