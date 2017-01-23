using Microsoft.Azure.Mobile.Server.Authentication;
using Microsoft.Azure.Mobile.Server.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web.Http;

namespace TPTwo.Controllers
{
    [MobileAppController]
    public class GetIdentityController : ApiController
    {
        // GET api/getidentity
        //        public string Get()
        //        {
        //            return "Hello World!";
        //        }
        public class UserInfo
        {
           public string firstname { get; set; }
           public string surname { get; set; } 
           public string fbID { get; set; }
           public string accesstoken { get; set; }


        }

        [HttpGet, Route("api/getIdentity")]
        public async Task<UserInfo> GetUserIdentity(HttpRequestMessage request = null)
        {
            var info = new UserInfo();
            try
            {
                var cp = User as ClaimsPrincipal;
                var id = cp.FindFirst(ClaimTypes.NameIdentifier);

                var creds = await User.GetAppServiceIdentityAsync<FacebookCredentials>(request ?? Request);

                info.firstname = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value ?? "";
                info.accesstoken = creds.AccessToken;
                info.surname = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value ?? "";
                info.fbID = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "";

                return info;

            }

            catch (Exception e)
            {
                throw;
            }
        }


        //[HttpGet, Route("api/getIdentityData")]
        //public async Task<UserInfo> GetUserId(HttpRequestMessage request = null)
        //{
        //    ClaimsPrincipal principal = user as ClaimsPrincipal;
        //    string provider = principal.FindFirst("http://schemas.microsoft.com/identity/claims/identityprovider").Value;

        //    ProviderCredentials creds = null;
        //    if (string.Equals(provider, "facebook", StringComparison.OrdinalIgnoreCase))
        //    {
        //        creds = await user.GetAppServiceIdentityAsync<FacebookCredentials>(request);
        //    }
        //    else if (string.Equals(provider, "google", StringComparison.OrdinalIgnoreCase))
        //    {
        //        creds = await user.GetAppServiceIdentityAsync<GoogleCredentials>(request);
        //    }

        //    var temp = creds.UserClaims;

        //    if (creds != null)
        //    {
        //        UserInfo _usrinfo = new UserInfo();

        //        _usrinfo.firstName = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value ?? string.Empty;
        //        _usrinfo.lastName = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value ?? string.Empty;
        //        _usrinfo.DOB = creds.Provider + ":" + creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.DateOfBirth)?.Value ?? string.Empty;

        //        var id = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

        //        _usrinfo.ID = creds.Provider + ":" + id;

        //        if (provider.Equals("facebook"))
        //        {

        //            _usrinfo.pictureURI = $"https://graph.facebook.com/{id}/picture?type=large";
        //            _usrinfo.email = creds.UserClaims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value ?? string.Empty;

        //        }
        //        if (provider.Equals("google"))
        //        {
        //            _usrinfo.email = creds.UserId;
        //            _usrinfo.pictureURI = creds.UserClaims.FirstOrDefault(c => c.Type == "picture")?.Value ?? string.Empty;

        //        }
        //        return _usrinfo;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}




        string _userId;


        public string UserId
        {
            get
            {
                if (_userId == null) { }
                {
                    var claimsUser = (ClaimsPrincipal)User;
                    var id = claimsUser?.FindFirst(ClaimTypes.NameIdentifier);

                    if (id != null)
                        _userId = id.Value;
                }
                return _userId;
            }

        }


        // Post api/getidentity
        public string Post()
        {
            return "Hello World!";
        }



    }
}
