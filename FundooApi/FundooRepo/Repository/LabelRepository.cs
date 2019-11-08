// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelRepository" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.LabelModel;
using FundooRepo.Context;
using FundooRepo.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FundooRepo.Interface.ILabelRepository" />
    public class LabelRepository : ILabelRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelRepository"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public LabelRepository(UserContext user)
        {
            this.userContext = user;
        }

        /// <summary>
        /// Addlabels the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string Addlabel(LabelModel labelModel)
        {
            LabelModel add = new LabelModel()
            {
                Email = labelModel.Email,
                Label = labelModel.Label                

            };
            this.userContext.Label.Add(add);
            this.userContext.SaveChanges();
            return "DONE";


        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public Task UpdateLabel(LabelModel labelModel)
        {
            LabelModel label = userContext.Label.Where(i => i.Id == labelModel.Id).FirstOrDefault();
            if (label != null)
            {
                label.Email = labelModel.Email;
                label.Label = labelModel.Label;

                userContext.Label.Update(label);
            }
            return Task.Run(() => userContext.SaveChanges());
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public Task DeleteLabel(int Id)
        {
            LabelModel label = userContext.Label.Where(i => i.Id == Id).FirstOrDefault();
            if (label != null)
            {


                userContext.Label.Remove(label);
            }
            return Task.Run(() => userContext.SaveChanges());
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public List<LabelModel> GetList()
        {
            return this.userContext.Label.ToList<LabelModel>();
        }
        public List<LabelModel> ListofLabel(string Email)
        {
            bool label = userContext.Label.Any(p => p.Email == Email);
            if (label)
            {


                return userContext.Label.Where(p => p.Email == Email).ToList();
            }
            else
            {
                return null;
            }
        }


    }
}
