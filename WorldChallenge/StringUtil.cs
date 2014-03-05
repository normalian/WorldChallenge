using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldChallenge
{
    static public class StringUtil
    {
        static public bool IsRearrange(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            var ret = str1.ToArray().Except(str2.ToArray());
            return !ret.Any();
        }
    }
}
