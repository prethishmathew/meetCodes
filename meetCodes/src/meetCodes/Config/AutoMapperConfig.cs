using AutoMapper;
using MeetCodes.Data.Models;
using MeetCodes.MeetCodeDTO;

namespace meetCodes.Config
{
    public class AutoMapperConfig
    {
        public static void Map()
        {
            //Need Some way to Generate the Mapping Automatically. And Move this to BootStrapper in Plugins
            Mapper.Initialize(cfg =>
            {               
                cfg.CreateMap<MeetCode, MeetCodesDto>();
                cfg.CreateMap<MeetCodesDto, MeetCode>();
            });
        }

    }
}
