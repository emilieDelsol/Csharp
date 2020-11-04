using System;
using System.Collections.Generic;

namespace testBattleDev04112020
{
    class Program
    {
		static void Main(string[] args)
        {
            
            List<ProductionLine> allProductionsLines = CapturePhoneAndOsVersion();

            Dictionary<int, int> osVersionInventory = CreateInventoryOfOsVersionProductionLines(allProductionsLines);

            int infectedOsVersion = identifyInfectedOs(allProductionsLines, osVersionInventory);

            int infectedProductionLineVersion = IdentifyPhoneProductionVersion(infectedOsVersion, allProductionsLines);

            ExportInfectedProductionLine(infectedProductionLineVersion);

        }

        private static int CaptureNumberOfPhoneProductionLines()
        {
            string line = Console.ReadLine();
            int phonesNumbers = Convert.ToInt32(line);
            return phonesNumbers;
        }

        private static void ExportInfectedProductionLine(int infectedProductionLineVersion)
        {
            Console.WriteLine(infectedProductionLineVersion);
        }

        private static List<ProductionLine> CapturePhoneAndOsVersion()
        {
            int phonesNumbers = CaptureNumberOfPhoneProductionLines();
            List<ProductionLine> allProductionsLines = new List<ProductionLine>();

            for (int index = 0; index < phonesNumbers; index++)
            {
                string phoneProductionVersionLine = Console.ReadLine();
                string[] phoneProductionVersionSplited = phoneProductionVersionLine.Split(" ");

                string phoneProductVersionAsString = phoneProductionVersionSplited[0];
                int phoneProductionVersion = Convert.ToInt32(phoneProductVersionAsString);

                string osVersionAsString = phoneProductionVersionSplited[1];
                int osVersion = Convert.ToInt32(osVersionAsString);


                ProductionLine productionLine = new ProductionLine(phoneProductionVersion, osVersion);
                allProductionsLines.Add(productionLine);

            }

            return allProductionsLines;
        }

        private static Dictionary<int, int> CreateInventoryOfOsVersionProductionLines(List<ProductionLine> allProductionsLines)
        {
            Dictionary<int, int> osVersionInventory = new Dictionary<int, int>();
            foreach (ProductionLine productionLine in allProductionsLines)
            {
                int osVersion = productionLine.GetOsVersion();
                int numberOfProductionLine = 0;
                if (osVersionInventory.ContainsKey(osVersion))
                {
                    numberOfProductionLine = osVersionInventory[osVersion];
                }
                else
                {
                    numberOfProductionLine = 0;
                    osVersionInventory.Add(osVersion, numberOfProductionLine);
                }

                numberOfProductionLine++;
                osVersionInventory[osVersion] = numberOfProductionLine;
            }

            return osVersionInventory;
        }

        private static int identifyInfectedOs(List<ProductionLine> allProductionsLines, Dictionary<int, int> osVersionInventory)
        {
            foreach (KeyValuePair<int, int> numberOfProductionLinesForOsVersion in osVersionInventory)
            {
                int numberOfProductionLine = numberOfProductionLinesForOsVersion.Value;
                if (numberOfProductionLine == 1)
                {
                    int infectedOsVersion = numberOfProductionLinesForOsVersion.Key;
                    return infectedOsVersion;

                }
            }
            return -1;

        }

        private static int IdentifyPhoneProductionVersion(int infectedOsVersion, List<ProductionLine> allProductionsLines)
        {
            foreach (ProductionLine productionLine in allProductionsLines)
            {
                if (productionLine.GetOsVersion() == infectedOsVersion)
                {
                    return productionLine.GetPhoneProductionVersion();
                }

            }
            return -1;
        }
    }
}
