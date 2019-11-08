// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountmanager" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccountManager
    {
        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task<string> RegistrationAsync(UserModel userModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);
        /// <summary>
        /// Facebooks the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> FacebookLoginAsync(LoginModel loginModel);
        /// <summary>
        /// Googles the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> GoogleLoginAsync(LoginModel loginModel);
        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task<string> ResetPasswordAsync(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Forgets the password asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        Task<string> ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel);
        /// <summary>
        /// Finds the by email async2.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<UserModel> FindByEmailAsync2(string email);
    }
}
