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
        None = 14,
        Three_Days = 3,
        Five_Days = 5,
        Seven_Days = 7,
        Not_Selected = 0
    }

    public class DeskQuote : Desk
    {
        public string customerName;
        public string rushDays;
        public DateTime dateOrdered;
        public float basePrice = 200;
        public float total;

        public DeskQuote(int width, int depth, int numdrawers, string material, string name, string rush, DateTime date) : base(width, depth, numdrawers, material)
        {
            SetDepth(depth);
            SetWidth(width);
            SetDrawers(numdrawers);
            SetMaterial(material);
            SetName(name);
            SetRush(rush);
            SetDate(date);
            SetTotal(float.Parse(FindTotalPrice()));

        }
        //setters
        private void SetName(string name)
        {
            customerName = name;
        }
        private void SetRush(string rush)
        {
            rushDays = rush;
        }
        private void SetDate(DateTime date)
        {
            dateOrdered = date;
        }
        private void SetTotal(float totalV)
        {
            total = totalV;
        }
        //getters
        public string GetCustomerName()
        {
            return customerName;
        }
        public string GetRush()
        {
            return rushDays;
        }
        public DateTime GetDateTime()
        {
            return dateOrdered;
        }
        public float GetTotal()
        {
            return total;
        }
        public float GetArea()
        {
            return GetWidth() * GetDepth();
        }
        public float GetBase()
        {
            return basePrice;
        }
        //operations
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
            float deskArea = GetArea();
            if (deskArea > 1000)
            {
                return (deskArea - 1000).ToString();
            }
            return "0";
        }

        public float FindDrawerPrice()
        {
            return (50 * GetDrawers());
        }

        public float FindMaterialPrice() 
        { float value;
            switch (GetDeskMaterial()){
                case "Pine":
                    value = (float)DesktopMaterial.Pine;
                    break;
                case "Laminate":
                    value = (float)DesktopMaterial.Laminate;
                    break;
                case "Veneer":
                    value = (float)DesktopMaterial.Veneer;
                    break;
                case "Oak":
                    value = (float)DesktopMaterial.Oak;
                    break;
                case "Rosewood":
                    value = (float)DesktopMaterial.Rosewood;
                    break;
                default:
                    value = (float)DesktopMaterial.Not_Selected;
                    break;
            }
            return value;
        }

        public string FindRushPrice()
        {
            float deskArea = GetArea();

            int[,] rushOrderPrices = GetRushOrder();

            switch (rushDays)
            {
                case "3":
                    if (deskArea < 1000)
                        return rushOrderPrices[0, 0].ToString();
                    else if (deskArea > 2000)
                        return rushOrderPrices[0, 2].ToString();
                    else
                        return rushOrderPrices[0, 1].ToString();

                case "5":
                    if (deskArea < 1000)
                        return rushOrderPrices[1, 0].ToString();
                    else if (deskArea > 2000)
                        return rushOrderPrices[1, 2].ToString();
                    else
                        return rushOrderPrices[1, 1].ToString();

                case "7":
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
            float totalPrice = basePrice;
            totalPrice += float.Parse(FindAreaPrice());
            totalPrice += FindDrawerPrice();
            totalPrice += FindMaterialPrice();
            totalPrice += float.Parse(FindRushPrice());
            return totalPrice.ToString();
        }
    }
}
