using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelBattle
{
    class ServerEmu
    {
        public static bool Close { get; set; } = false;

        public static bool[] availableColours { get; } = new bool[12] { false, false, false, true, true, false,
                                                                        false, false, false, false, false, false };
        /*public static bool[] availableColours { get; } = new bool[12] { true, true, true, true, true, true,
                                                                          true, true, true, true, true, true };*/

        private static string username;
        public static string getUsername()
        {
            return username;
        }

        private static int coins;
        public static int getCoins()
        {
            return coins;
        }

        public static bool TryLogin(string login, string password)
        {
            username = "User_1";
            return true;
        }
    }
}
