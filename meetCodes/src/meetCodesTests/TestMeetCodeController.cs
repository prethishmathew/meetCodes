using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using meetCodes.Controllers;
using meetCodes.Services.MeetCodeService;
using MeetCodes.Data.Models;
using MeetCodes.Data.UnitOfWork;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace meetCodesTests
{
    public class TestMeetCodeController
    {
        [Theory]
        [MemberData(nameof(GenerateMeetCode))]
        public async void TestMeetCodeControllerGet(MeetCode meetCode)
        {
         
            Mock<IMeetCodeService> mockUOW = new Mock<IMeetCodeService>();
            mockUOW.Setup(t => t.GetMeetCodesAsync(It.IsAny<string>())).Returns(Task.FromResult(meetCode));
            var sut = new MeetCodeController(mockUOW.Object);
            var actionResult = await sut.Get(meetCode.Description);

            var contentResult = actionResult as OkObjectResult;

            Assert.IsType<OkObjectResult>(actionResult);
            Assert.NotNull(contentResult);

            var retunMeetcode = contentResult.Value as MeetCode;
            Assert.IsType<MeetCode>(retunMeetcode);
            Assert.Equal(meetCode.Code, retunMeetcode.Code);

        }

        [Theory]
        [MemberData(nameof(GenerateMeetCode))]
        public async void TestMeetCodeControllerPost(MeetCode meetCode)
        {

            Mock<IMeetCodeService> mockUOW = new Mock<IMeetCodeService>();
            mockUOW.Setup(t => t.CreateMeetCodesAsync(It.IsAny<MeetCode>())).Returns(Task.FromResult(meetCode));
            var sut = new MeetCodeController(mockUOW.Object);
            var actionResult = await sut.Post(meetCode);
            var contentResult = actionResult as OkObjectResult;

            Assert.IsType<OkObjectResult>( actionResult);
            Assert.NotNull(contentResult);

            var retunMeetcode = contentResult.Value as MeetCode;
            Assert.IsType<MeetCode>(retunMeetcode);
            Assert.Equal(meetCode.Code,retunMeetcode.Code);

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
