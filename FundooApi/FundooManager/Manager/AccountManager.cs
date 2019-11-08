
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountManager" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooModel.UserModels;
using FundooRepo;
using FundooRepo.Context;
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
    /// <seealso cref="FundooManager.Interface.IAccountManager" />
    public class AccountManager : IAccountManager
    {
        /// <summary>
        /// 
        /// </summary>
        //private readonly IConfiguration configuration;
        private readonly IAccountRepository accountRepo;
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="accountRepo">The account repo.</param>
        public AccountManager(IAccountRepository accountRepo)
        {
            this.accountRepo = accountRepo;
        }


        public async Task<string> RegistrationAsync(UserModel userModel)
        {
            
            try
            {
                
                await this.accountRepo.CreateAsync(userModel);
                return "Registration Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            try
            {
                await this.accountRepo.LoginAsync(loginModel);
                return "Login Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> FacebookLoginAsync(LoginModel loginModel)
        {
            try
            {
                await this.accountRepo.FacebookLoginAsync(loginModel);
                return "FacebookLogin Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> GoogleLoginAsync(LoginModel loginModel)
        {
            try
            {
                await this.accountRepo.GoogleLoginAsync(loginModel);
                return "GoogleLogin Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                await this.accountRepo.ResetPasswordAsync(resetPasswordModel);
                return "ResetPassword Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel)
        {
            try
            {
                await this.accountRepo.ForgetPasswordAsync(forgetPasswordModel);
                return "ForgetPassword Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<UserModel> FindByEmailAsync2(string email)
        {
             var res=this.accountRepo.FindByEmailAsync1(email);
            return res;
        }
    }
}
