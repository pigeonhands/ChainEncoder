using ChainLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DefaultLinks
{
    public class Base64 : ILink
    {
        public string Name { get { return "Base64"; } }

        public string Decode(string input)
        {
            return WebUtility.UrlDecode(Encoding.UTF8.GetString(Convert.FromBase64String(input)));
        }

        public string Encode(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }
    }
}
