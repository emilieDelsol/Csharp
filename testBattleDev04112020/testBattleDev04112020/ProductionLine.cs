using System;

namespace testBattleDev04112020
{
    public class ProductionLine
    {
        private int phoneProductionVersion;
        private int osVersion;

        public ProductionLine(int phoneProductionVersion, int osVersion)
        {   
            this.phoneProductionVersion = phoneProductionVersion;
            this.osVersion = osVersion;
        }
                
        public int GetOsVersion()
        {
            return osVersion;   
        }

        public int GetPhoneProductionVersion()
        {
            return phoneProductionVersion;
        }
    }
}