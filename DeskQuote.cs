using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;

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

        public static int[,] GetRushOrder()
        {
            int[,] rushOrderPrices = new int[3, 3];
            try
            {
                string filename = Path.GetDirectoryName(Application.ExecutablePath);
                filename += @"\rushOrderPrices.txt";
                StreamReader reader;
                reader = new StreamReader(filename);

                int x = 0; 
                int y = 0;

                while (reader.EndOfStream == false)
                {
                    rushOrderPrices[y, x] = Convert.ToInt32(reader.ReadLine());
                    x++;
                    if (x > 2)
                    {
                        x = 0;
                        y++;
                    }
                    
                    if(y > 2)
                    {
                        break;
                    }
                }

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred!");
            }

            return rushOrderPrices;
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

            int[,] rushOrderPrices = GetRushOrder();

            switch (rushDays)
            {
                case RushOrder.Three_Days:
                    if (deskArea < 1000)
                        return rushOrderPrices[0, 0].ToString();
                    else if (deskArea > 2000)
                        return rushOrderPrices[0, 2].ToString();
                    else
                        return rushOrderPrices[0, 1].ToString();

                case RushOrder.Five_Days:
                    if (deskArea < 1000)
                        return rushOrderPrices[1, 0].ToString();
                    else if (deskArea > 2000)
                        return rushOrderPrices[1, 2].ToString();
                    else
                        return rushOrderPrices[1, 1].ToString();

                case RushOrder.Seven_Days:
                    if (deskArea < 1000)
                        return rushOrderPrices[2, 0].ToString();
                    else if (deskArea > 2000)
                        return rushOrderPrices[2, 2].ToString();
                    else
                        return rushOrderPrices[2, 1].ToString();
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
