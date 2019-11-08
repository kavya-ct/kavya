// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.CollaboratorModel;
using FundooRepo.Context;
using FundooRepo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FundooRepo.Interface.ICollaboratorRepository" />
    public class CollaboratorRepository: ICollaboratorRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorRepository"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public CollaboratorRepository(UserContext user)
        {
            this.userContext = user;
        }

        public string Addcollaborator(CollaboratorModel collaboratorModel)
        {
            CollaboratorModel add = new CollaboratorModel()
            {
                Id = collaboratorModel.Id,
                Noteid = collaboratorModel.Noteid,
                Sendemail= collaboratorModel.Sendemail,
                Receiveremail = collaboratorModel.Receiveremail

            };
            this.userContext.collaboratorDetails.Add(collaboratorModel);
            this.userContext.SaveChanges();
            return "DONE";


        }

        public Task Updatecollaborator(CollaboratorModel collaboratorModel)
        {
            CollaboratorModel collaborator = userContext.collaboratorDetails.Where(i => i.Id == collaboratorModel.Id).FirstOrDefault();
            if (collaborator != null)
            {
                collaborator.Noteid = collaboratorModel.Noteid;
                collaborator.Sendemail = collaboratorModel.Sendemail;
                collaborator.Receiveremail = collaboratorModel.Receiveremail;

                userContext.collaboratorDetails.Update(collaborator);
            }
            return Task.Run(() => userContext.SaveChanges());

        }

        public Task DeleteCollaborator(int Id)
        {
            CollaboratorModel collaborator = userContext.collaboratorDetails.Where(i => i.Id == Id).FirstOrDefault();
            if (collaborator != null)
            {
                userContext.collaboratorDetails.Remove(collaborator);
            }
            return Task.Run(() => userContext.SaveChanges());
        }

        public List<CollaboratorModel> GetList()
        {
            return this.userContext.collaboratorDetails.ToList<CollaboratorModel>();
        }
        public List<CollaboratorModel> ListofCollaborator(string Sendemail)
        {
            bool collaborator = userContext.collaboratorDetails.Any(p => p.Sendemail == Sendemail);
            if (collaborator)
            {


                return userContext.collaboratorDetails.Where(p => p.Sendemail == Sendemail).ToList();
            }
            else
            {
                return null;
            }
        }



    }
}
