using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meztli
{
    class EncodeHelper
    {
        public string messageString { get; set; }
        public string qRString { get; set; }
        public string message { get; set; }

        public EncodeHelper(Information info, Part part)
        {
            messageString = EncodeForMessage(info, part);
            message = EncodeInfo(info, part);
            qRString = EncodeForQR(info, part);
        }

        private string EncodeInfo(Information info, Part part)
        {
            return string.Concat(part.partNumber,Resources.BREAK,
                                Resources.TAESUNG, Resources.BREAK,
                                part.displayName, Resources.BREAK,
                                (info.date.Year % 100) + "." + info.date.Month.ToString("d2") + "." + info.date.Day);
        }

        private string EncodeForMessage(Information info, Part part)
        {
            return string.Concat(Resources.TRIPLE_BREAK +
                                part.partNumber +
                                Resources.DOUBLE_BREAK +
                                Resources.TAESUNG +
                                Resources.DOUBLE_BREAK +
                                part.displayName +
                                Resources.DOUBLE_BREAK +
                                (info.date.Year%100) + Resources.BACKSLASH + info.date.Month + Resources.BACKSLASH + info.date.Year);
        }

        private string EncodeForQR(Information info, Part part)
        {
            return ControlCharacters.Convert(string.Concat(
                /*Header*/          Resources.HEADER,
                /*Vendor Code*/     "V" + info.vendorCode,
                /*Devide*/          Resources.DEVIDE,
                /*Part Number*/     "P" + part.partNumber,
                /*Devide*/          Resources.DEVIDE,
                /*ALC Code*/        "S" + string.Empty,
                /*Devide*/          Resources.DEVIDE,
                /*EO Num*/          "E" + string.Empty,
                /*Devide*/          Resources.DEVIDE,
                /*Date*/            "T" + info.date.ToString("yyMMdd"),
                /*4M Info*/         Resources._4M_S1 + info.shift + Resources._4M_1A,
                /*Serial Num*/      info.serialNumber,
                /*Devide*/          Resources.DEVIDE,
                /*Separate Code*/   "1A" + string.Empty,
                /*Devide*/          Resources.DEVIDE,
                /*ISIR/4M*/         "M" + Resources._4M_Y,
                /*Devide*/          Resources.DEVIDE,
                /*Vendor space*/    "C" + string.Empty,
                /*Devide*/          Resources.DEVIDE,
                /*Trailer*/         Resources.TRAILER));
        }
    }
}
