using ChainLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultLinks
{
    /// <summary>
    /// http://www.dotnetperls.com/rot13
    /// </summary>
    public class ROT13 : ILink
    {
        public string Name { get { return "ROT13"; } }

        public string Decode(string input)
        {
            return Run(input);
        }

        public string Encode(string input)
        {
            return Run(input);
        }

        private string Run(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
