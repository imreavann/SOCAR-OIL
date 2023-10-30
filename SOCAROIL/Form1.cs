using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OilProjects
{
    public partial class Form1 : Form
    {
        Oil oil = new Oil();

        public Form1()
        {
            
            InitializeComponent();
          
        }

        private void benzinSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (benzinSelectBox.SelectedIndex)
            {
                case 0:
                    oil.oilPrice = 1.00;
                    break;
                case 1:
                    oil.oilPrice = 1.50;
                    break;
                case 2:
                    oil.oilPrice = 2.00;
                    break;
                case 3:
                    oil.oilPrice = 2.50;
                    break;
                case 4:
                    oil.oilPrice = 3.00;
                    break;
                default:
                    break;
            }
            oilPriceLbr.Text = oil.oilPrice.ToString();
        }

        private void priceRbt_CheckedChanged(object sender, EventArgs e)
        {
            if (priceRbt.Checked)
            {
                moneyMtxtbox.ReadOnly = false;
            }
            else
            {
                
                moneyMtxtbox.Clear();
                benzinTotalLb.Text = "0";
                moneyMtxtbox.ReadOnly = true;
            }
        }



        private void litrRbtr_CheckedChanged(object sender, EventArgs e)
        {
            if (litrRbtr.Checked)
            {
                litrMtxtbox.ReadOnly = false;
            }
            else
            {
                litrMtxtbox.Clear();
                benzinTotalLb.Text = "0";
                litrMtxtbox.ReadOnly = true;
            }
        }

        private void moneyMtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(moneyMtxtbox.Text, out double money))
            {
               
                oil.oil = money;
                string priceTotal = (oil.oil / oil.oilPrice).ToString();
                benzinTotalLb.Text = priceTotal;
                
                oil.oilMoney += double.Parse(priceTotal);
                oil.totalMoney += double.Parse(priceTotal);
            }
          
        }

        private void litrMtxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void litrMtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(litrMtxtbox.Text, out double money))
            {
                oil.oil = money;
                string litrTotal = (oil.oil / oil.oilPrice).ToString();
                benzinTotalLb.Text = litrTotal;
                oil.oilMoney += double.Parse(litrTotal);
                oil.totalMoney += double.Parse(litrTotal);
            }
        }

        private void CoffeUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (CoffeeBox.Checked)
            {
                if (CoffeUpDown.Value < 1)
                {
                    kafeTotalAmmoLbr.Text = "0";
                }
                else
                {

                    int coffeeCount = (int)CoffeUpDown.Value;
                    double coffeePrice = 2.00;
                    double totalPrice = coffeeCount * coffeePrice;

                    oil.coffemoney += totalPrice;
                    oil.totalMoney += totalPrice;
                    kafeTotalAmmoLbr.Text = oil.coffemoney.ToString();
                }
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (snickersBox.Checked)
            {
                if (SnickersUpDown.Value < 1)
                {
                    kafeTotalAmmoLbr.Text = "0";
                }
                else
                {

                    int snickersCount = (int)SnickersUpDown.Value;
                    double snickersPrice = 1.50;
                    double totalPrice = snickersCount * snickersPrice;

                    oil.coffemoney += totalPrice;
                    oil.totalMoney += totalPrice;
                    kafeTotalAmmoLbr.Text = oil.coffemoney.ToString();
                }
            }
            
        }

        private void redbullUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (redbullBox.Checked)
            {
                if (redbullUpDown.Value < 1)
                {
                    kafeTotalAmmoLbr.Text = "0";
                }
                else
                {

                    int redbullCount = (int)redbullUpDown.Value;
                    double redbullPrice = 4;
                    double totalPrice = redbullCount * redbullPrice;

                    oil.coffemoney += totalPrice;
                    oil.totalMoney += totalPrice;
                    kafeTotalAmmoLbr.Text = oil.coffemoney.ToString();
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (spriteBox.Checked)
            {
                if (spirteUpDown.Value < 1)
                {
                    kafeTotalAmmoLbr.Text = "0";
                }
                else
                {

                    int spriteCount = (int)spirteUpDown.Value;
                    double spritePrice = 1.20;
                    double totalPrice = spriteCount * spritePrice;

                    oil.coffemoney += totalPrice;
                    oil.totalMoney += totalPrice;
                    kafeTotalAmmoLbr.Text = oil.coffemoney.ToString();
                }
            }
        }

        private void fantaUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (fantaBox.Checked)
            {
                if (fantaUpDown.Value < 1)
                {
                    kafeTotalAmmoLbr.Text = "0";
                }
                else
                {

                    int fantaCount = (int)fantaUpDown.Value;
                    double fantaPrice = 1.20;
                    double totalPrice = fantaCount * fantaPrice;

                    oil.coffemoney += totalPrice;
                    oil.totalMoney += totalPrice;
                    kafeTotalAmmoLbr.Text = oil.coffemoney.ToString();
                }
            }
        }

        private void basketBtr_Click(object sender, EventArgs e)
        {
            double total = oil.coffemoney += oil.oilMoney;
            TotalBuylbr.Text = total.ToString();
        }

    }


    public class Oil
    {
        public double totalMoney { get; set; }
        public double oil { get; set; }
        public double totalOilAmount { get; set; }
        public double oilPrice { get; set; }
        public double coffemoney { get; set; }
        public double oilMoney { get; set; }
    }
}
