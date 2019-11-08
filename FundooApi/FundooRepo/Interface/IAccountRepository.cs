// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAccountRepository" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooModel.UserModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace FundooRepo.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Creates the asynchronous.
        /// 
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task CreateAsync(UserModel userModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<UserModel> LoginAsync(LoginModel loginModel);
        /// <summary>
        /// Facebooks the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<UserModel> FacebookLoginAsync(LoginModel loginModel);
        /// <summary>
        /// Googles the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<UserModel> GoogleLoginAsync(LoginModel loginModel);

        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task<UserModel> ResetPasswordAsync(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Forgets the password asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        Task ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel);
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<IdentityUser> FindByEmailAsync(string email);
        /// <summary>
        /// Generates the password reset.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task GeneratePasswordReset(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Finds the by email async1.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<UserModel> FindByEmailAsync1(string email);

    }
}
