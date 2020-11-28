using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelBattle
{
    class Constants
    {
        public enum ColoursIndexes
        {
            RED, GREEN, BLUE, WHITE, BLACK, ORANGE, PURPLE, YELLOW, LIGHT_GREEN, LIGHT_BLUE, PINK, GRAY
        }

        public class Colours
        {
            public static readonly int[] RED = { 255, 0, 0 };
            public static readonly int[] GREEN = { 0, 255, 0 };
            public static readonly int[] BLUE = { 0, 0, 255 };
            public static readonly int[] WHITE = { 255, 255, 255 };
            public static readonly int[] BLACK = { 0, 0, 0 };
            public static readonly int[] ORANGE = { 255, 128, 0 };
            public static readonly int[] PURPLE = { 191, 0, 255 };
            public static readonly int[] YELLOW = { 255, 255, 0 };
            public static readonly int[] LIGHT_GREEN = { 191, 255, 0 };
            public static readonly int[] LIGHT_BLUE = { 0, 255, 255 };
            public static readonly int[] PINK = { 255, 0, 191 };
            public static readonly int[] GRAY = { 128, 128, 128 };
        }
    }
}
