using System.Collections;
using System.Collections.Generic;
using MeetCodes.Data.Models;

namespace MeetCodes.Data.TestSources
{
    public class TestSourceMeetCode : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // ...
            yield return new object[]
            {
                new MeetCode()
                    {Address1 = "33", Description = "Test", State = "MN", ZipCode = "56431", CodeString = "PradsPlace"}
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
   
}
