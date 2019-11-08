// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="kavya ct"/>
// -------------------------------------------------------------------------------------------
using FundooManager.Interface;
using FundooManager.Manager;
using FundooModel.Model.UserModels;
using FundooModel.UserModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        /// <summary>
        /// The account
        /// </summary>
        private readonly IAccountManager account;
        private readonly ApplicationSetting _appsetting;
        public AccountController(IAccountManager account, IOptions<ApplicationSetting> appsetting)
        {
            this.account = account;
            _appsetting = appsetting.Value;
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Registration(UserModel userModel)
        {
            try
            {
                var result = await account.RegistrationAsync(userModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(LoginModel loginModel)
        {

            try
            {
                var result = await account.LoginAsync(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("facebooklogin")]
        public async Task<IActionResult> FacebookLoginAsync(LoginModel loginModel)
        {

            try
            {
                var result = await account.FacebookLoginAsync(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("googlelogin")]
        public async Task<IActionResult> GoogleLoginAsync(LoginModel loginModel)
        {

            try
            {
                var result = await account.GoogleLoginAsync(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await account.ResetPasswordAsync(resetPasswordModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("ForgetPassword")]

        public async Task<IActionResult> ForgetPasswordAsync(ForgetPasswordModel forgetPasswordModel)
        {
            try
            {
                var result = await this.account.ForgetPasswordAsync(forgetPasswordModel);
                return this.Ok(new { result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("log")]
        public async Task<IActionResult> Log(LoginModel login)
        {
            try
            {
                var result = await this.account.LoginAsync(login);
                if (result != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                           new Claim("Email", login.Email)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appsetting.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    return Ok(new { token });
                }
                else
                {
                    return BadRequest(new { message = "Not valid" });
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        [Route("Decode")]
        public async Task<object> UserProfile()
        {
            string email = User.Claims.First(c => c.Type == "Email").Value;
            var user = await account.FindByEmailAsync2(email);
            return new
            {
                user.Email,
                user.Password
            };
        }
    }
    }


