using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Application.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }

        /* [HttpPost]
         public async Task<object> Login([FromBody] UserEntity userEntity, [FromBody] ILoginService service)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }
             if (userEntity == null)
             {
                 BadRequest();
             }
             try
             {
                 var result = await service.FindbyLogin(userEntity);
                 if (result != null)
                 {
                     return result;
                 }
                 else
                 {
                     return NotFound();
                 }
             }
             catch (ArgumentException ex)
             {
                 return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);

             }


         }*/

        [HttpPost]
        public async Task<object> Login([FromBody] UserEntity userEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (userEntity == null)
            {
                BadRequest();
            }
            try
            {
                var result = await _service.FindbyLogin(userEntity);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);

            }


        }


    }
}
