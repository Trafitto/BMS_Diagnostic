using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Diagnostic_2
{
    class InstalledProgram
    {
        public string displayName { get; set; }
        public string displayVersion { get; set; }
        public string installDate { get; set; }

        public float estimatedSize { get; set; }
        public string installLocation { get; set; }
        public string publisher { get; set; }

        public InstalledProgram (string displayName, string displayVersion, string installDate, float estimatedSize,
            string installLocation, string publisher)
        {
            this.displayName = displayName;
            this.displayVersion = displayVersion;
            this.installDate = installDate;
            this.estimatedSize = estimatedSize;
            this.installLocation = installLocation;
            this.publisher = publisher;
        }
    }
}
