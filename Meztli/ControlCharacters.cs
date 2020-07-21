using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Meztli
{
    public static class ControlCharacters
    {
        private static Dictionary<string, char> controlChars = new Dictionary<string, char>()
        {
            {"NUL",'\u0000'},
            {"SOH",'\u0001'},
            {"STX",'\u0002'},
            {"ETX",'\u0003'},
            {"EOT",'\u0004'},
            {"ENQ",'\u0005'},
            {"ACK",'\u0006'},
            {"BEL",'\u0007'},
            {"BS",'\u0008'},
            {"HT",'\u0009'},
            {"LF",'\u000A'},
            {"VT",'\u000B'},
            {"FF",'\u000C'},
            {"CR",'\u000D'},
            {"SO",'\u000E'},
            {"SI",'\u000F'},
            {"DLE",'\u0010'},
            {"DC1",'\u0011'},
            {"DC2",'\u0012'},
            {"DC3",'\u0013'},
            {"DC4",'\u0014'},
            {"NAK",'\u0015'},
            {"SYN",'\u0016'},
            {"ETB",'\u0017'},
            {"CAN",'\u0018'},
            {"EM",'\u0019'},
            {"SUB",'\u001A'},
            {"ESC",'\u001B'},
            {"FS",'\u001C'},
            {"GS",'\u001D'},
            {"RS",'\u001E'},
            {"US",'\u001F'},
            {"DEL",'\u007F'},
        };

        public static string Convert(string text)
        {
            return Regex.Replace(text, @"\{(.*?)\}|\<(.*?)\>", Evaluator);
        }

        private static string Evaluator(Match m)
        {
            string actualValue = m.Value.Substring(1, m.Value.Length - 2).ToUpper();
            if (controlChars.ContainsKey(actualValue))
            {
                return controlChars[actualValue].ToString();
            }
            return m.Value;
        }
    }
}
