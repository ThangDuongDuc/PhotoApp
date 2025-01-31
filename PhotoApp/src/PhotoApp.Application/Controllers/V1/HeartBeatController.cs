﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoApp.Domain.Constants;

namespace PhotoApp.Application.Controllers.V1
{
    [Route("api/" + ApiConstants.ServiceName + "/v{api-version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    [Produces("application/json")]
    public class HeartBeatController : ControllerBase
    {
        /// <summary>
        /// Heart Beat Controller
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ping")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<bool>> PingAsync()
        {
            return Task.FromResult<ActionResult<bool>>(Ok(true));
        }
    }
}
