using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelBattle
{
    class Colour : GameItem
    {
        public int[] CurrentColour { get; set; }
        public override string id
        {
            get
            {
                return "colour";
            }
        }
    }
}
