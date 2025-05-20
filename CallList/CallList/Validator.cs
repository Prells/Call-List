using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallList
{
    public class Validator
    {
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = $"{name} is a required field.\n";
            }
            return msg;
        }
    }
}
