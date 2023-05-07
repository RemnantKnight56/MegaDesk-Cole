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
    }

    public struct Quote
    {
        public String customerName;
        public Desk deskOrdered;
        public RushOrder rushDays;
    }

    public class DeskQuote
    {


        public int findDeskPrice(Desk desk) 
        {
            int deskPrice = 200;
            deskPrice += desk.width * desk.depth;
            deskPrice += 50 * desk.numDrawers;
            switch (desk.deskMaterial)
            {
                case DesktopMaterial.Pine:
                    deskPrice += 50;
                    break;

                case DesktopMaterial.Laminate:
                    deskPrice += 100;
                    break;

                case DesktopMaterial.Veneer:
                    deskPrice += 125;
                    break;

                case DesktopMaterial.Oak:
                    deskPrice += 200;
                    break;

                case DesktopMaterial.Rosewood:
                    deskPrice += 300;
                    break;
            }
            return deskPrice;
        }

        public int findOrderPrice(Desk desk, RushOrder rushDays)
        {
            int orderPrice = 0;
            int deskArea = desk.width * desk.depth;

            switch (rushDays)
            {
                case RushOrder.Three_Days:
                    if (deskArea < 1000)
                        orderPrice += 60;
                    else if (deskArea > 2000)
                        orderPrice += 80;
                    else
                        orderPrice += 70;
                    break;

                case RushOrder.Five_Days:
                    if (deskArea < 1000)
                        orderPrice += 40;
                    else if (deskArea > 2000)
                        orderPrice += 60;
                    else
                        orderPrice += 50;
                    break;

                case RushOrder.Seven_Days:
                    if (deskArea < 1000)
                        orderPrice += 30;
                    else if (deskArea > 2000)
                        orderPrice += 40;
                    else
                        orderPrice += 35;
                    break;
            }
            return orderPrice;
        }

        public int findTotalPrice (Desk desk, RushOrder rushDays)
        {
            int totalPrice = 0;
            totalPrice += findDeskPrice(desk);
            totalPrice += findOrderPrice(desk, rushDays);
            return totalPrice;
        }
    }
}
