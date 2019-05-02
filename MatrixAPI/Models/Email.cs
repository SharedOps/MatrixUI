using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MatrixAPI.Models
{
    public class Email
    {

        [IgnoreDataMember]
        public string FromAddress { get; set; } = "info@saaramsha.com";

        public string ToAddress { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }
    }
}
