using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meztli
{
    public class Information
    {
        public string vendorCode { get; set; }
        public DateTime date { get; set; }
        public string serialNumber { get; set; }
        public string shift { get; set; }

        private string getShiftNumber(string shift)
        {
            if (shift.Equals(Resources.DIA))
            {
                return (1).ToString();
            }
            else
            {
                return (2).ToString();
            }
        }
        public Information(string vendorCode, DateTime date, string serialNumber, string shift)
        {
            this.vendorCode = vendorCode;
            this.date = date;
            this.serialNumber = serialNumber;
            this.shift = getShiftNumber(shift);
        }
    }
}
