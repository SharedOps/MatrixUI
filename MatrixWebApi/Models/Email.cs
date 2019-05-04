using System.Runtime.Serialization;
using System.Configuration;
using MatrixWebApi.CrossCutting;

namespace MatrixWebApi.Models
{
    public class Email
    {
        [IgnoreDataMember]
        public string FromAddress { get; set; } = ConfigurationManager.AppSettings[Constants.AppSMTPFromAddressKey];

        public string ToAddress { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }
    }
}