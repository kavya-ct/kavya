// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILabelRepository" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.Model.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILabelRepository
    {
        /// <summary>
        /// Addlabels the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string Addlabel(LabelModel labelModel);
        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        Task UpdateLabel(LabelModel labelModel);
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task DeleteLabel(int Id);
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        List<LabelModel> GetList();
        /// <summary>
        /// Listofs the label.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<LabelModel> ListofLabel(string Email);


    }
}
