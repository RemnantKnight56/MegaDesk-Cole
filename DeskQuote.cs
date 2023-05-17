using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MegaDesk_Cole
{
    public enum RushOrder
    {
        None,
        Three_Days,
        Five_Days,
        Seven_Days,
        Not_Selected
    }

    public class DeskQuote
    {
        public String customerName;
        public Desk deskOrdered;
        public RushOrder rushDays;
        public DateTime dateOrdered;
        public const string basePrice = "200";
        public int total;

        public DeskQuote()
        {
            customerName = "";
            deskOrdered = new Desk();
            rushDays = RushOrder.Not_Selected;
            dateOrdered = DateTime.Now;
            total = 0;
        }

        public string FindAreaPrice()
        {
            int deskArea = deskOrdered.Width * deskOrdered.Depth;
            if (deskArea > 1000)
            {
                return (deskArea - 1000).ToString();
            }
            else
            {
                return "0";
            }
        }

        public string FindDrawerPrice()
        {
            return (50 * deskOrdered.NumDrawers).ToString();
        }

        public string FindMaterialPrice() 
        {
            return deskOrdered.DeskMaterial switch
            {
                DesktopMaterial.Pine => "50",
                DesktopMaterial.Laminate => "100",
                DesktopMaterial.Veneer => "125",
                DesktopMaterial.Oak => "200",
                DesktopMaterial.Rosewood => "300",
                _ => "0",
            };
        }

        public string FindRushPrice()
        {
            int deskArea = deskOrdered.Width * deskOrdered.Depth;


            switch (rushDays)
            {
                case RushOrder.Three_Days:
                    if (deskArea < 1000)
                        return "60";
                    else if (deskArea > 2000)
                        return "80";
                    else
                        return "70";

                case RushOrder.Five_Days:
                    if (deskArea < 1000)
                        return "40";
                    else if (deskArea > 2000)
                        return "60";
                    else
                        return "50";

                case RushOrder.Seven_Days:
                    if (deskArea < 1000)
                        return "30";
                    else if (deskArea > 2000)
                        return "40";
                    else
                        return "35";
            }
            return "0";
        }

        public string FindTotalPrice ()
        {
            int totalPrice = Convert.ToInt32(basePrice);
            totalPrice += Convert.ToInt32(FindAreaPrice());
            totalPrice += Convert.ToInt32(FindDrawerPrice());
            totalPrice += Convert.ToInt32(FindMaterialPrice());
            totalPrice += Convert.ToInt32(FindRushPrice());
            total = totalPrice;
            return totalPrice.ToString();
        }
    }
}
