using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal a = 0;
        decimal m1 = 0;
        decimal m2 = 0;
        decimal m3 = 0;
        decimal m4 = 0;
        private void order()//訂購餐點明細
        {
            label9.Text = numericUpDown1.Value + "份高山高麗菜、"
                          + (numericUpDown2.Value) * 2 + "片大溪豆乾、"
                          + (numericUpDown3.Value) * 2 + "片深海海帶、"
                          + numericUpDown4.Value + "份高級肉片";
        }

        private void total()//訂購總金額
        {

            m1 = numericUpDown1.Value * 30;
            m2 = numericUpDown2.Value * 15;
            m3 = numericUpDown3.Value * 15;
            m4 = numericUpDown4.Value * 40;
            a = m1 + m2 + m3 + m4;
            label12.Text = "高山高麗菜30*" + numericUpDown1.Value+
                           "\n大溪豆乾15*" + numericUpDown2.Value+
                           "\n深海海帶15*" + numericUpDown3.Value+
                           "\n高級肉片40*" + numericUpDown4.Value+
                           "\n=" + a;
        }

        private void amount()//鈔票數量
        {
            int thousand = (int)a /1000;
            int fivehundred = (int)a % 1000 / 500;
            int fifty = (int)a % 500 / 50;
            int ten = (int)a % 50/10;
            int five = (int)a % 10/5;
            int one = (int)a % 5/1;
            label11.Text = "1000元：" + thousand + "張\n " +
                           "500元：" + fivehundred + "張\n " +
                           "50元：" + fifty + "個\n " +
                           "10元：" + ten + "個\n " +
                           "5元：" + five + "個\n " +
                           "1元：" + one + "個\n ";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            order();
            total();
            amount();
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            order();
            total();
            amount();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            order();
            total();
            amount();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            order();
            total();
            amount();
        }


    }
}
