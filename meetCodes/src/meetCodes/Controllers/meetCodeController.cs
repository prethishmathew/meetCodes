using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using meetCodes.Services.MeetCodeService;

namespace meetCodes.Controllers
{
    [Route("api/v1/meetcodes")]
    public class MeetCodeController:Controller
    {
        private readonly IMeetCodeService _meetCodeService;
        public MeetCodeController(IMeetCodeService meetCodeService)
        {
            _meetCodeService = meetCodeService;
        }

        public async Task<IActionResult> Get(string id)
        {            
            return Ok(await _meetCodeService.GetMeetCodesAsync(id));
        }

        public async Task<IActionResult> Post(string id)
        {
            return Ok(await _meetCodeService.CreateMeetCodesAsync(id));
        }
    }
}
