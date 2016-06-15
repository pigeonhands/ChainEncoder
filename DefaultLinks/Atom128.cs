using ChainLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultLinks
{
    /// <summary>
    /// http://www.fluxbytes.com/csharp/atom-128-algorithm-in-c/
    /// </summary>
    public class Atom128 : ILink
    {
        public string Name { get { return "Atom128"; } }

        public string Decode(string input)
        {
            string key = "/128GhIoPQROSTeUbADfgHijKLM+n0pFWXY456xyzB7=39VaqrstJklmNuZvwcdEC";
            StringBuilder result = new StringBuilder();

            int[] indexes = new int[4];
            int[] chars = new int[3];
            int i = 0;

            do
            {
                indexes[0] = key.IndexOf(input[i++]);
                indexes[1] = key.IndexOf(input[i++]);
                indexes[2] = key.IndexOf(input[i++]);
                indexes[3] = key.IndexOf(input[i++]);

                chars[0] = (indexes[0] << 2) | (indexes[1] >> 4);
                chars[1] = (indexes[1] & 15) << 4 | (indexes[2] >> 2);
                chars[2] = (indexes[2] & 3) << 6 | indexes[3];

                result.Append((char)chars[0]);

                if (indexes[2] != 64)
                    result.Append((char)chars[1]);

                if (indexes[3] != 64)
                    result.Append((char)chars[2]);
            }
            while (i < input.Length);

            return result.ToString();
        }

        public string Encode(string input)
        {
            string key = "/128GhIoPQROSTeUbADfgHijKLM+n0pFWXY456xyzB7=39VaqrstJklmNuZvwcdEC";
            StringBuilder result = new StringBuilder();

            int i = 0;
            int[] indexes = new int[4];
            int[] chars = new int[3];

            do
            {
                chars[0] = i + 1 > input.Length ? 0 : (int)input[i++];
                chars[1] = i + 2 > input.Length ? 0 : (int)input[i++];
                chars[2] = i + 3 > input.Length ? 0 : (int)input[i++];

                indexes[0] = chars[0] >> 2;
                indexes[1] = ((chars[0] & 3) << 4) | (chars[1] >> 4);
                indexes[2] = ((chars[1] & 15) << 2) | (chars[2] >> 6);
                indexes[3] = chars[2] & 63;

                if ((char)chars[1] == 0)
                {
                    indexes[2] = 64;
                    indexes[3] = 64;
                }
                else if ((char)chars[2] == 0)
                {
                    indexes[3] = 64;
                }

                foreach (int index in indexes)
                {
                    result.Append(key[index]);
                }
            }
            while (i < input.Length);

            return result.ToString();
        }
    }
}
