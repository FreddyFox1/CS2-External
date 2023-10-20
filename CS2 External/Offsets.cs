using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2_External_Cheat
{
    public class Offsets
    {
        // bases
        public int ViewMatrix = 0x1882570;

        public int localPlayer = 0x1881288;
        public int entityList = 0x16AE880;

        // Attributes
        public int teamNum = 0x3BF;
        public int jumpFlag = 0x3c8;
        public int health = 0x32c;
        public int origin = 0xCD8;
    }
}
