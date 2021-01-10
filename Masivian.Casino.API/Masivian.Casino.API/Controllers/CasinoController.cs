using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Masivian.Casino.Business.Interfaces;
using Masivian.Casino.Entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Masivian.Casino.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CasinoController : ControllerBase
    {
        #region Properties
        private readonly ILogger<CasinoController> _logger;
        private readonly ICasinoBusiness _business;
        #endregion

        #region Constructor
        public CasinoController(ILogger<CasinoController> logger, ICasinoBusiness business)
        {
            _business = business ?? throw new ArgumentNullException(nameof(business));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        #endregion

        #region Methods
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<string>> CreateRoulette()
        {
            try
            {
                return Ok(await _business.CreateRouletteAsync());
            }
            catch (Exception ex)
            {
                _logger.LogError("Se presento el siguiente error: {0}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<bool>> OpenRouletteById([Required] string id)
        {
            try
            {
                return Ok(await _business.OpenRouletteByIdAsync(id));
            }
            catch (Exception ex)
            {
                _logger.LogError("Se presento el siguiente error: {0}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<bool>> CreateBet([FromHeader(Name = "userId")][Required] string userId,
           [FromBody][Required] BetRequest betRequest)
        {
            try
            {
                betRequest.User = userId;
                return Ok(await _business.CreateBet(betRequest));
            }
            catch (Exception ex)
            {
                _logger.LogError("Se presento el siguiente error: {0}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(RouletteResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<RouletteResult>> ClosedRouletteById([Required] string id)
        {
            try
            {
                return Ok(await _business.ClosedRouletteById(id));
            }
            catch (Exception ex)
            {
                _logger.LogError("Se presento el siguiente error: {0}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<RouletteStatus>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<RouletteStatus>>> GetRoulettes()
        {
            try
            {
                return Ok(await _business.GetRoulettes());
            }
            catch (Exception ex)
            {
                _logger.LogError("Se presento el siguiente error: {0}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        #endregion        
    }
}