using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainLink
{
    public interface ILink
    {
        string Name { get;}
        string Encode(string input);
        string Decode(string input);
    }
}
