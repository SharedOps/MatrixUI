using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixAPI.Models
{
    public class Email
    {
        public string FromAddress { get; set; }

        public string ToAddress { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }
    }
}
