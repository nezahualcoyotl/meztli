using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meztli
{
    public class Part
    {
        public string number { get; set; }
        public string description { get; set; }
        public string project { get; set; }
        public string partNumber { get; set; }
        public string partNumberSales { get; set; }
        public string partName { get; set; }
        public string png { get; set; }
        public string pac { get; set; }
        public string pacKg { get; set; }
        public string cav { get; set; }
        public string equip { get; set; }
        public string displayName { get; set; }

        public Part(string number, string description, string project, string partNumber, string partNumberSales, string partName, string png, string pac, string pacKg, string cav, string equip, string displayName)
        {
            this.number = number;
            this.description = description;
            this.project = project;
            this.partNumber = partNumber;
            this.partNumberSales = partNumberSales;
            this.partName = partName;
            this.png = png;
            this.pac = pac;
            this.pacKg = pacKg;
            this.cav = cav;
            this.equip = equip;
            this.displayName = displayName;
        }
    }

    public class CollectionHandler
    {
        public Dictionary<int, Part> Parts = new Dictionary<int, Part>()
        {
            {1, new Part("1", "HVCC", "YDM", "D529HFCAA01", "97279A7000", "DUCT ASSY-(A)FLOOR SHOWER", "P269", "7000", "0.115", "1", "1", "1 DUCT ASSY-(A)FLOOR SHOWER")},
            {2, new Part("2", "HVCC", "YDM", "D530HFCAA01", "97282A7000 ", "DUCT ASSY-FLOOR SHOWER", "P268", "7000", "0.106", "1", "1", "2 DUCT ASSY-FLOOR SHOWER")},
            {3, new Part("3", "HVCC", "YDM", "D143GDBAA01", "D143GDBAA01", "COVER-HTR CORE", "N / A", "N / A", "0.065", "2", "3", "3 COVER-HTR CORE")},
            {4, new Part("4", "HVCC", "YDM", "B102YN9AA01", "B102YN9AA01", "FAN-COOL'G", "N/A", "N/A", "0.375", "1", "3", "4 FAN-COOL'G")},
            {5, new Part("5", "HVCC", "YDM", "B119ATDAA01", "B119ATDAA01", "SHROUD ASSY-COOL'G FAN", "N/A", "N/A", "0.89", "1", "5", "5 SHROUD ASSY-COOL'G FAN")},
            {6, new Part("5-1", "HVCC", "YDM", "B101ATDAA", "B101ATDAA", "SHROUD COOL'G FAN", "N/A", "N/A", "0.245", "1", "5", "5-1 SHROUD COOL'G FAN")},
            {7, new Part("5-2", "HVCC", "YDM", "B101ATDAB01", "B101ATDAB01", "RESERVOIR TANK", "N / A", "N / A", "0.245", "2", "4", "5-2 RESERVOIR TANK")},
            {8, new Part("6", "HVCC", "YDM", "B119ENFAA01", "B119ENFAA01", "SHROUD ASSY-COOL'G FAN", "N/A", "N/A", "0.95", "1", "5", "6 SHROUD ASSY-COOL'G FAN")},
            {9, new Part("7", "HVCC", "YDM", "B101ATBEA01", "B101ATBEA01", "SHROUD ASSY-COOL'G FAN", "N/A", "N/A", "0.63", "1", "4", "7 SHROUD ASSY-COOL'G FAN")},
        };

        public Part FindPart(string displayName)
        {
            foreach (KeyValuePair<int, Part> part in Parts)
            {
                if (displayName == part.Value.displayName)
                {
                    return part.Value;
                }
            }
            return null;
        }
    }
}
