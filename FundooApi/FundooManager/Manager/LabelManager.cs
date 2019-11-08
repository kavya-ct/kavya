// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelManager" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.Model.LabelModel;
using FundooRepo.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FundooManager.Interface.ILabel" />
    public class LabelManager : ILabel
    {
        /// <summary>
        /// 
        /// </summary>
        //private readonly IConfiguration configuration;
        private readonly ILabelRepository labelRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManager"/> class.
        /// </summary>
        /// <param name="labelRepository">The label repository.</param>
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }


        public string Add(LabelModel labelModel)
        {
            
                 this.labelRepository.Addlabel(labelModel);
                 return "ADDED Successfully";
            
         
        }

        public async Task<string> Update(LabelModel labelModel)
        {
            try
            {
                await this.labelRepository.UpdateLabel(labelModel);
                return "UPDATE Successfully";
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
                await this.labelRepository.DeleteLabel(Id);
                return "Delete Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<LabelModel> List(string Email)
        {
            try
            {
                var result = this.labelRepository.ListofLabel(Email);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
