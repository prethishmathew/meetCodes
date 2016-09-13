namespace MeetCodes.MeetCodeDTO
{
    public class ResultBase 
    {
        public ResultBase()
        {
            ResultSuccess = "Success";
            ResultCode = "0";
            ResultMessage = "";

        }
        public string ResultSuccess { get; set; }

        public string ResultCode { get; set; }

        public string ResultMessage { get; set; }
    }
}
