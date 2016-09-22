using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using meetCodes.Services.MeetCodeService;
using MeetCodes.MeetCodeDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace meetCodes.Controllers
{
    [Route("api/v1/meetcodes")]
    [Produces("application/json")]
    public class MeetCodeController : Controller
    {
        private readonly IMeetCodeService _meetCodeService;

        public MeetCodeController(IMeetCodeService meetCodeService)
        {
            _meetCodeService = meetCodeService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _meetCodeService.GetMeetCodesAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MeetCodesDto meetCode)
        {
            try
            {
                return Ok(await _meetCodeService.CreateMeetCodesAsync(meetCode));
            }
            catch (DbUpdateException )
            {
                return BadRequest("This meet code is already taken. Please Use another one ");
            }
            
        }
    }
}
