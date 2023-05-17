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
        Rosewood,
        Not_Selected
    }
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial DeskMaterial { get; set; }

        public const int deskWidthMax = 96;
        public const int deskWidthMin = 24;
        public const int deskDepthMax = 48;
        public const int deskDepthMin = 12;
        public const int maxDrawers = 7;
        public const int minDrawers = 0;

        public Desk()
        {
            Width = 0;
            Depth = 0;
            NumDrawers = 0;
            DeskMaterial = DesktopMaterial.Not_Selected;
        }
    }
}
