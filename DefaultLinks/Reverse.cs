using ChainLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultLinks
{
    public class Reverse : ILink
    {
        public string Name { get { return "Reverse"; } }

        public string Decode(string input)
        {
            return string.Concat(input.Reverse());
        }

        public string Encode(string input)
        {
            return string.Concat(input.Reverse());
        }
    }
}
