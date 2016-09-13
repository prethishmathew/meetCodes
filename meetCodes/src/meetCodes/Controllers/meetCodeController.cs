using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using meetCodes.Services.MeetCodeService;
using MeetCodes.MeetCodeDTO;

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
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {            
            return Ok(await _meetCodeService.GetMeetCodesAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(MeetCodesDto meetCode)
        {
            return Ok(await _meetCodeService.CreateMeetCodesAsync(meetCode));
        }
    }
}
