namespace common.coremodels
{
    //https://www.strathweb.com/2016/09/strongly-typed-configuration-in-asp-net-core-without-ioptionst/
    public class AppSettings
    {
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public EmailSettings EmailSettings { get; set; }
        public bool IsEmailSendWhenErrorOccured { get; set; }
        public bool IsPostSentryWhenErrorOccured { get; set; }
    }

    public class EmailSettings
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
    }
}
