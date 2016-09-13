using System.Collections.Generic;
using System.Threading.Tasks;
using meetCodes.Controllers;
using meetCodes.Services.MeetCodeService;
using MeetCodes.Data.Models;
using MeetCodes.MeetCodeDTO;
using MeetCodes.MeetCodeDTO.TestSource;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace meetCodesTests
{
    public class TestMeetCodeController
    {
        [Theory]
        //[MemberData(nameof(GenerateMeetCode))]
        [ClassData(typeof(TestSourceMeetCodesDto))]
        public async void TestMeetCodeControllerGet(MeetCodesDto meetCode)
        {
         
            var mockUow = new Mock<IMeetCodeService>();
            mockUow.Setup(t => t.GetMeetCodesAsync(It.IsAny<string>())).Returns(Task.FromResult(meetCode));
            var sut = new MeetCodeController(mockUow.Object);
            var actionResult = await sut.Get(meetCode.Description);

            var contentResult = actionResult as OkObjectResult;

            Assert.IsType<OkObjectResult>(actionResult);
            Assert.NotNull(contentResult);

            var retunMeetcode = contentResult.Value as MeetCodesDto;
            Assert.IsType<MeetCodesDto>(retunMeetcode);
            Assert.Equal(meetCode.CodeString, retunMeetcode.CodeString);

        }

        [Theory]
        //[MemberData(nameof(GenerateMeetCode))]
        [ClassData(typeof(TestSourceMeetCodesDto))]
        public async void TestMeetCodeControllerPost(MeetCodesDto meetCode)
        {

            var mockUow = new Mock<IMeetCodeService>();
            mockUow.Setup(t => t.CreateMeetCodesAsync(It.IsAny<MeetCodesDto>())).Returns(Task.FromResult(meetCode));
            var sut = new MeetCodeController(mockUow.Object);
            var actionResult = await sut.Post(meetCode);
            var contentResult = actionResult as OkObjectResult;

            Assert.IsType<OkObjectResult>( actionResult);
            Assert.NotNull(contentResult);

            var retunMeetcode = contentResult.Value as MeetCodesDto;
            Assert.IsType<MeetCodesDto>(retunMeetcode);
            Assert.Equal(meetCode.CodeString,retunMeetcode.CodeString);

        }
        


        public static IEnumerable<object[]> GenerateMeetCode
        {
            get
            {

                return new[]
                {
                new object[] {
                    new MeetCode()
                    { Address1 = "33", Description = "Test", State = "MN", ZipCode = "56431", Code = 12345 } },

                };
            }
        }

    }
}
