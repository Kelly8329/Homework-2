using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            dateTimePicker2.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            TimeSpan ts = end.Subtract(start);
            int totaltime = ts.Days * 24 * 60 + ts.Hours * 60 + ts.Minutes + 1;
            int money = 0;

            /*  停車2小時內，每半小時30元
                超過2小時但未滿4小時，每半小時40元
                超過4小時以上每半小時60元
                未滿半小時部分不計算*/

            if (totaltime <= 120)//小於2小時
            {
                money = (totaltime / 30) * 30;
            }

            else if(totaltime > 120 && totaltime < 240)
            {
                money = (totaltime / 30) * 40;
            }

            else
            {
                money = (totaltime / 30) * 60;
            }

            MessageBox.Show("停車費為：" + money.ToString("c0"));
        }
    }
}
