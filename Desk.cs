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
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300,
        Not_Selected = 0
    }

    public class Desk
    {
        public int Width;
        public int Depth;
        public int NumDrawers;
        public string DeskMaterial;

        public const int deskWidthMax = 96;
        public const int deskWidthMin = 24;
        public const int deskDepthMax = 48;
        public const int deskDepthMin = 12;
        public const int maxDrawers = 7;
        public const int minDrawers = 0;

        public Desk(int width, int depth, int numdrawers, string material)
        {
            Width = width;
            Depth = depth;
            NumDrawers = numdrawers;
            DeskMaterial = material;
        }

        // setters
        protected void SetWidth(int width)
        {
            Width = width;
        }
        protected void SetDepth(int depth)
        {
            Depth = depth;
        }
        protected void SetDrawers(int drawers)
        {
            NumDrawers = drawers;
        }
        protected void SetMaterial(string material)
        {
            DeskMaterial = material;
        }
        //getters
        internal int GetWidth()
        {
            return Width;
        }
        internal int GetDepth()
        {
            return Depth;
        }
        internal int GetDrawers()
        {
            return NumDrawers;
        }
        internal string GetDeskMaterial()
        {
            return DeskMaterial;
        }

    }
}
