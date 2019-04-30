using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOOP
{
    public partial class FrmOOP : Form
    {
        public FrmOOP()
        {
            InitializeComponent();
        }
        ClsBanking user1;

        private void button1_Click(object sender, EventArgs e)
        {
            user1 = new ClsBanking();
            MessageBox.Show(user1.balance.ToString("C2"));
        }
        private void button2_Click(object sender, EventArgs e)
        {

            // GEt
            this.label1.Text = user1.balance.ToString("C2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set
            user1.balance = decimal.Parse(this.textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //可寫可讀
            user1.P1 = 1000;
            MessageBox.Show(user1.P1.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //唯讀
            //user1.P2 = 100;
            MessageBox.Show(user1.P2.ToString());
        }
        ClsBanking sss = new ClsBanking();
        ClsBanking vvv = new ClsBanking();

        private void button7_Click(object sender, EventArgs e)
        {
            //唯寫
            // user1.P3 = 100;
            //int w = user1.P3;
            //sss.aaa = 100;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(100, 200));
            list.Add(new Point(100, 800));
            list.Add(new Point(100, 100));
            list.Add(new Point(100, 400));
            this.dataGridView1.DataSource = list;
            //不用資料繫節
            //for (int i = 0; i < list.Count; i++)
            //{
            //    this.listBox2.Items.Add(list[i].X+","+ list[i].Y);
            //}

            this.listBox2.DataSource = list;
            //屬性資料繫節
            List<ClsBanking> Mylist = new List<ClsBanking>();
            Mylist.Add(new ClsBanking { balance = 999, P1 = 100, P3 = 200 });
            Mylist.Add(new ClsBanking { balance = 888 });
            this.dataGridView2.DataSource = Mylist;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.dataGridView1.DataSource = nwDataSet1.Products;
            this.dataGridView2.DataSource = nwDataSet1.Categories;
            this.dataGridView3.DataSource = nwDataSet1.Customers;

            MessageBox.Show(nwDataSet1.Products.Rows[0][1].ToString());
            //針對Products的Row中的ProductName屬性取值
            MessageBox.Show(nwDataSet1.Products[0].ProductName);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClsBanking user1 = new ClsBanking();
            MessageBox.Show(user1[0].ToString());
            try
            {
                MessageBox.Show(user1[10].ToString());
            }
            catch (IndexOutOfRangeException EX)
            {

                MessageBox.Show(EX.Message);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //可以給予不同存取規則
            ClsBanking user1 = new ClsBanking();
            MessageBox.Show(user1.P4.ToString());
            //無法set user1.P4=99;
        }

            ClsBanking user2 = new ClsBanking();
        private void button13_Click(object sender, EventArgs e)
        {

            user2.Deposit(1000);
            label4.Text = user2._balance.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            user2.Withdraw(1000);
            label4.Text = user2._balance.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClsBanking rr = new ClsBanking();
            //屬性多載 索引子
            MessageBox.Show(rr[1].ToString());
            MessageBox.Show(rr["1"].ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //方法多載
            //public void TEst(int....)
            //public void TEst(string,string...)
          
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ClsBanking user = new ClsBanking();//建構子
            MessageBox.Show(user._balance.ToString());
            ClsBanking user2 = new ClsBanking(1000);//建構子
            MessageBox.Show(user._balance.ToString());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClsBanking user = new ClsBanking();
            user = null;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ClsBanking user = new ClsBanking();
            user.Disposed();//......

            //using (ClsBanking user2 = new ClsBanking())//interface
            //{

            //}
        }

        private void button19_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5000; i++)
            {
                NewMemory x = new NewMemory();
            }
            label9.Text = NewMemory.counters.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //傳統建構子初始化
            //AB ss = new AB();
            //AB ss1 = new AB(8,8,8);
            //List<AB> abs = new List<AB>();
            //abs.Add(ss);
            //abs.Add(ss1);
            //this.dataGridView4.DataSource = abs;
            /******************************/
            //物件初始化
            AB sfd = new AB { p1 = 100, p2 = 100, p3 = 200 };
            List<AB> abs = new List<AB>();
            abs.Add(sfd);
            abs.Add(new AB { p1 = 22, p2 = 33, p3 = 44 });
            this.dataGridView4.DataSource = abs;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClsBanking.InterestRate.ToString());//靜態屬性
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }
    }

    class AB
    {
        public int p1 { get; set; }
        public int p2 { get; set; }
        public int p3 { get; set; }
        public AB()
        {
            
        }
        public AB(int P1)
        {
            p1 = P1;
        }

        public AB(int P1, int P2, int P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }
    }


    class NewMemory
    {
        internal static int counters;
        public NewMemory()
        {
            counters++;
        }
        ~NewMemory()
        {
            counters--;
        }
    }
}
