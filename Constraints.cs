using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBot
{
    public class Constraints
    {
        #region HK
        public static string[] strModelNumberGen
                = new string[] { 
                "MG472", 
                "MG482", 
                "MG492", 
                "MG4F2", 
                "MG4H2", 
                "MG4J2", 
                "MG4A2", 
                "MG4C2", 
                "MG4E2", 
                "MGA82", 
                "MGA92", 
                "MGAA2", 
                "MGAH2", 
                "MGAJ2", 
                "MGAK2", 
                "MGAC2", 
                "MGAE2", 
                "MGAF2"
            };

        public static int[] iProductTypeGen = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        public static int[] iMemSizeGen = new int[] { 16, 16, 16, 64, 64, 64, 128, 128, 128, 16, 16, 16, 64, 64, 64, 128, 128, 128 };
        public static int[] iColorGen = new int[] { 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1 };
        public static int[] iPriorityGen = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };
        #endregion
        #region HK
        public static string[] strModelNumberHK
                = new string[] { 
                "MG472ZP/A", 
                "MG482ZP/A", 
                "MG492ZP/A", 
                "MG4F2ZP/A", 
                "MG4H2ZP/A", 
                "MG4J2ZP/A", 
                "MG4A2ZP/A", 
                "MG4C2ZP/A", 
                "MG4E2ZP/A", 
                "MGA82ZP/A", 
                "MGA92ZP/A", 
                "MGAA2ZP/A", 
                "MGAH2ZP/A", 
                "MGAJ2ZP/A", 
                "MGAK2ZP/A", 
                "MGAC2ZP/A", 
                "MGAE2ZP/A", 
                "MGAF2ZP/A"
            };

        public static int[] iProductTypeHK = new[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1};
        public static int[] iMemSizeHK = new int[] { 16, 16, 16, 64, 64, 64, 128, 128, 128, 16, 16, 16, 64, 64, 64, 128, 128, 128 };
        public static int[] iColorHK = new int[] { 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1 };
        public static int[] iPriorityHK = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };
        #endregion

        #region AU

        public static string[] strModelNumberAU = new string[]
            {
                "MG4A2X/A",
                "MGAK2X/A",
                "MGA82X/A",
                "MGAF2X/A",
                "MG472X/A",
                "MG4F2X/A",
                "MG482X/A",
                "MGA92X/A",
                "MGAJ2X/A",
                "MGAE2X/A",
                "MG4J2X/A",
                "MG4E2X/A",
                "MGAH2X/A",
                "MG4C2X/A",
                "MGAA2X/A",
                "MG4H2X/A",
                "MG492X/A",
                "MGAC2X/A"
            };
        public static int[] iProductTypeAU = new int[] { 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1 };
        public static int[] iMemSizeAU = new int[]{128, 64, 16, 128, 16, 64, 16, 16, 64, 128, 64, 128, 64, 128, 16, 64, 16, 128};
        public static int[] iColorAU = new int[] {2, 1, 2, 1, 2, 2, 0, 0, 0, 0, 1, 1, 2, 0, 1, 0, 1, 2};
        #endregion

        #region DE German
        public static string[] strModelNumberDE = new string[]
            {
                "MG4J2ZD/A",
                "MG472ZD/A",
                "MGAJ2ZD/A",
                "MG4A2ZD/A",
                "MGAA2ZD/A",
                "MGAH2ZD/A",
                "MG4F2ZD/A",
                "MGAK2ZD/A",
                "MG4C2ZD/A",
                "MGA82ZD/A",
                "MGAC2ZD/A",
                "MGA92ZD/A",
                "MGAF2ZD/A",
                "MG492ZD/A",
                "MG4H2ZD/A",
                "MGAE2ZD/A",
                "MG482ZD/A",
                "MG4E2ZD/A"
            };
        public static int[] iProductTypeDE = new int[] {0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0};
        public static int[] iMemSizeDE = new int[] {64, 16, 64, 128, 16, 64, 64, 64, 128, 16, 128, 16, 128, 16, 64, 128, 16, 128};
        public static int[] iColorDE = new int[] { 1,2,0,2,1,2,2,1,0,2,2,0,1,1,0,0,0,1};
        #endregion

        #region CA

        public static string[] strModelNumberCA = new string[]
        {
            "MG3A2CL/A",
"MG3C2CL/A",
"MG3D2CL/A",
"MG3H2CL/A",
"MG3K2CL/A",
"MG3L2CL/A",
"MG3E2CL/A",
"MG3F2CL/A",
"MG3G2CL/A",
"MG9M2CL/A",
"MG9N2CL/A",
"MG9P2CL/A",
"MG9U2CL/A",
"MG9V2CL/A",
"MG9W2CL/A",
"MG9Q2CL/A",
"MG9R2CL/A",
"MG9T2CL/A"
        };

        #endregion
    }
}
