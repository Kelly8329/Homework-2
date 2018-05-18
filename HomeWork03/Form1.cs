using HomeWork08.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list1 = CreatproductData();
            var list2 = CreatsalesData();
            var stp = S_TotalPrice(list1, list2);
            dataGridView1.DataSource = stp;
            var ptp = P_TotalPrice(list1, list2);
            dataGridView2.DataSource = ptp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private List<MyData> CreatproductData()//建立產品資料(名稱、單價)
        {
            List<MyData> product = new List<MyData>();
            product.Add(new MyData { P_Name = "原子筆", Price = 12 });
            product.Add(new MyData { P_Name = "鉛筆", Price = 16 });
            product.Add(new MyData { P_Name = "橡皮擦", Price = 10 });
            product.Add(new MyData { P_Name = "直尺", Price = 14 });
            product.Add(new MyData { P_Name = "立可白", Price = 15 });
            return product;
        }

        private List<Sales> CreatsalesData()//建立銷售員銷售資料
        {
            List<Sales> sales = new List<Sales>();
            sales.Add(new Sales { Salesman = "Bill", P_Name = "原子筆", Amount = 33 });
            sales.Add(new Sales { Salesman = "Bill", P_Name = "鉛筆", Amount = 32 });
            sales.Add(new Sales { Salesman = "Bill", P_Name = "橡皮擦", Amount = 56 });
            sales.Add(new Sales { Salesman = "Bill", P_Name = "直尺", Amount = 45 });
            sales.Add(new Sales { Salesman = "Bill", P_Name = "立可白", Amount = 33 });
            sales.Add(new Sales { Salesman = "John", P_Name = "原子筆", Amount = 77 });
            sales.Add(new Sales { Salesman = "John", P_Name = "鉛筆", Amount = 33 });
            sales.Add(new Sales { Salesman = "John", P_Name = "橡皮擦", Amount = 68 });
            sales.Add(new Sales { Salesman = "John", P_Name = "直尺", Amount = 45 });
            sales.Add(new Sales { Salesman = "John", P_Name = "立可白", Amount = 23 });
            sales.Add(new Sales { Salesman = "David", P_Name = "原子筆", Amount = 43 });
            sales.Add(new Sales { Salesman = "David", P_Name = "鉛筆", Amount = 55 });
            sales.Add(new Sales { Salesman = "David", P_Name = "橡皮擦", Amount = 43 });
            sales.Add(new Sales { Salesman = "David", P_Name = "直尺", Amount = 67 });
            sales.Add(new Sales { Salesman = "David", P_Name = "立可白", Amount = 65 });
            return sales;
        }

        //業務員銷售總額
        private List<Scalculate> S_TotalPrice(List<MyData> list1, List<Sales> list2)
        {
            var result =
                from p in list1
                join s in list2
                on p.P_Name equals s.P_Name
                select
                new Scalculate
                { Salesman = s.Salesman, SalesTotalPrice = (p.Price * s.Amount) };

            var temp1 = result.Where((x) => x.Salesman == "Bill").Sum((y) => y.SalesTotalPrice);
            var temp2 = result.Where((x) => x.Salesman == "John").Sum((y) => y.SalesTotalPrice);
            var temp3 = result.Where((x) => x.Salesman == "David").Sum((y) => y.SalesTotalPrice);

            var list3 = new List<Scalculate>();
            list3.Add(new Scalculate { Salesman = "Bill", SalesTotalPrice = temp1 });
            list3.Add(new Scalculate { Salesman = "John", SalesTotalPrice = temp2 });
            list3.Add(new Scalculate { Salesman = "David", SalesTotalPrice = temp3 });

            //找出業務員最大銷售總金額
            var temp4 = list3.Max((x) => x.SalesTotalPrice);
            var temp5 = list3.Where((x) => x.SalesTotalPrice == temp4);
            foreach(var item in temp5)
                label4.Text = item.Salesman.ToString();

            return list3;
        }

        //產品銷售總額
        private List<Pcalculate> P_TotalPrice(List<MyData> list1, List<Sales> list2)
        {
            var result =
                 from p in list1
                 join t in list2
                 on p.P_Name equals t.P_Name
                 select
                 new Pcalculate
                 { P_Name = p.P_Name, ProductsTotalPrice = (p.Price * t.Amount) };

            var temp1 = result.Where((x) => x.P_Name == "原子筆").Sum((y) => y.ProductsTotalPrice);
            var temp2 = result.Where((x) => x.P_Name == "鉛筆").Sum((y) => y.ProductsTotalPrice);
            var temp3 = result.Where((x) => x.P_Name == "橡皮擦").Sum((y) => y.ProductsTotalPrice);
            var temp4 = result.Where((x) => x.P_Name == "直尺").Sum((y) => y.ProductsTotalPrice);
            var temp5 = result.Where((x) => x.P_Name == "立可白").Sum((y) => y.ProductsTotalPrice);

            var list4 = new List<Pcalculate>();
            list4.Add(new Pcalculate { P_Name = "原子筆", ProductsTotalPrice = temp1 });
            list4.Add(new Pcalculate { P_Name = "鉛筆", ProductsTotalPrice = temp2 });
            list4.Add(new Pcalculate { P_Name = "橡皮擦", ProductsTotalPrice = temp3 });
            list4.Add(new Pcalculate { P_Name = "直尺", ProductsTotalPrice = temp4 });
            list4.Add(new Pcalculate { P_Name = "立可白", ProductsTotalPrice = temp5 });

            // 找出產品最大銷售總金額
            var temp6 = list4.Max((x) => x.ProductsTotalPrice);          
            var temp7 = list4.Where((x) => x.ProductsTotalPrice == temp6);
            foreach (var item in temp7)
                label6.Text = item.P_Name.ToString();

            return list4;
        }
    }
}
