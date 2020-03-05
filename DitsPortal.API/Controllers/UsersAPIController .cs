using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DitsPortal.Common.Responses;
using DitsPortal.Common.StaticResources;
using DitsPortal.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace DitsPortal.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersAPIController : ControllerBase
    {
        #region readonly
        private readonly IUserService _userService;
        private readonly JsonSerializerSettings _serializerSettings;

        #endregion

        #region private
        private IOptions<AppSettings> _settings;
        private BaseResponse _response;
        private string _json = string.Empty;
        #endregion

        public UsersAPIController(IUserService userService, IOptions<AppSettings> settings)
        {
            _settings = settings;
            _userService = userService;
            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            _response = new BaseResponse();
        }


        [HttpGet]
        [Authorize]
        public async Task<ActionResult> test()
        {
            try
            {
                var user = User.Identity.Name;
                
                _json = JsonConvert.SerializeObject(_response, _serializerSettings);
                return new OkObjectResult(_json);
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.Status = false;
                _json = JsonConvert.SerializeObject(_response, _serializerSettings);
                return BadRequest(_json);
            }
        }
    }
}