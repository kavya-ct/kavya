//-------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya"/>
// --------------------------------------------------------------------------------------------------------------------

using FundooModel.UserModels;
using FundooRepo.Context;
using FundooRepo.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IAccountRepository" />

    public class AccountRepository : IAccountRepository
    {
        //  private readonly IConfiguration iconfiguration;
        private readonly UserContext userContext;
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        public AccountRepository(UserContext userContext)
        {
            this.userContext = userContext;
            //   this.configuration = configuration;

        }



        public Task CreateAsync(UserModel userModel)
        {
            try
            {
                UserModel userModel1 = new UserModel()
                {
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    Email = userModel.Email,
                    Password = userModel.Password,
                    CardType = userModel.CardType,
                };
                userContext.UserDetail.Add(userModel);
                return Task.Run(() => userContext.SaveChanges());
            }catch(Exception e) { throw new Exception(e.Message); }
        }

        public async Task<UserModel> LoginAsync(LoginModel loginModel)
        {
            try
            {
                var user = userContext.UserDetail.Where(p => p.Password == loginModel.Password && p.Email == loginModel.Email).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }





        public  Task<UserModel> FacebookLoginAsync(LoginModel loginModel)
        {
            try
            {

                var user = userContext.UserDetail.Where(p => p.Password == loginModel.Password && p.Email == loginModel.Email).FirstOrDefault();
                if (user != null)
                {
                    return Task.Run(()=> user);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public  Task<UserModel> GoogleLoginAsync(LoginModel loginModel)
        {
            try
            {
                var user = userContext.UserDetail.Where(p => p.Password == loginModel.Password && p.Email == loginModel.Email).FirstOrDefault();
                if (user != null)
                {
                    return Task.Run(() => user);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public  Task<UserModel> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            {
                try
                {
                    var user = userContext.UserDetail.Where(p => p.Password == resetPasswordModel.Password && p.Email == resetPasswordModel.Email).FirstOrDefault();
                    if (user != null)
                    {
                        var result = this.GeneratePasswordReset(resetPasswordModel);
                        return Task.Run(() => user);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }


        }
        public Task GeneratePasswordReset(ResetPasswordModel resetPasswordModel)
        {
            var result = userContext.UserDetail.Where(p => p.Email == resetPasswordModel.Email).Single();
            result.Password = resetPasswordModel.NewPassword;
            userContext.Update(result);
            return Task.Run(() => userContext.SaveChanges());

        }

        public async Task ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel)
        {
            try
            {
                // var user = await this.FindByEmailAsync(forgetPasswordModel.Email);
                //  if (user != null)
                {
                    var Fromemail = new MailAddress("kavyakushi67@gmail.com");
                    var fromPassword = "tanunatraj1v6";
                    var ToAddress = new MailAddress(forgetPasswordModel.Email);
                    string Subject = "Reset Password";
                    string Body = "To reset ur password click on Link";
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new NetworkCredential(Fromemail.Address, fromPassword),
                        EnableSsl = true,

                    };



                    using (var message = new MailMessage(Fromemail, ToAddress)
                    {
                        Subject = Subject,
                        Body = Body
                    })



                        try
                        {
                            smtp.Send(message);
                        }



                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                }
            }



            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

      
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
           UserModel model = this.userContext.UserDetail.Where(p =>  p.Email == email).FirstOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                Email = model.Email
            };
            return Task.Run(() => Iuser);

        }
        public async Task<UserModel> FindByEmailAsync1(string email)
        {
            //private UserContext usercontext;
        var user = this.userContext.UserDetail.Find(email);
            return user;
        }
}
    
}


















































