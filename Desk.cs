using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cole
{
    public enum DesktopMaterial
    {
        Pine,
        Laminate,
        Veneer,
        Oak,
        Rosewood
    }
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public DesktopMaterial deskMaterial { get; set; }

        public const int deskWidthMax = 96;
        public const int deskWidthMin = 24;
        public const int deskDepthMax = 48;
        public const int deskDepthMin = 12;
    }
}
