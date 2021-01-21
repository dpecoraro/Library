using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Appsettings
    {
        public LogLevel LogLevel { get; set; }

        public string AllowedHosts { get; set; }

        public Security Security { get; set; }
    }

    public class Security
    {
        public string Secret { get; set; }

        public byte[] GetKey => Encoding.ASCII.GetBytes(this.Secret);
    }
}
