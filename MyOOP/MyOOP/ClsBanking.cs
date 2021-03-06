﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOOP
{
    class ClsBanking
    {


        public ClsBanking()//建構子
        {
            
        }
        public ClsBanking(decimal money)//建構子多載
        {
            _balance += money;
        }

        public decimal _balance { get; set; }
        //將資料分裝在類別
        public decimal balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value > 0) _balance = value;
            }
        }
        private int _P1;
        public int P1
        {
            get { return _P1; }
            set { _P1 = value; }
        }


        public int P2 { get { return 100; } }
        public int P3 { get; set; }

        private int[] num = { 5, 12, 4, 6 };
        //自訂索引子
        public int this[int i]
        {
            get
            {
                if (i > num.Length - 1 || i < 0)
                {
                    throw new IndexOutOfRangeException("範圍不正確");
                }
                return num[i];
            }
        }
        //多載
        public int this[string s]
        {
            get
            {
                int i = int.Parse(s);
                if (i > num.Length - 1 || i < 0)
                {
                    throw new IndexOutOfRangeException("範圍不正確");
                }
                return num[i];
            }
        }




        //可以給予不同存取規則
        public int P4 { get; private set; }
        //自動實做屬性
        public int P5 { get; set; }
        public int P6;
        
        public void Deposit(decimal money)
        {
            this._balance += money;
        }//存錢

        public decimal Withdraw(decimal money)
        {
            this._balance -= money;
            return this._balance;
        }//提款

        public static int InterestRate//靜態屬性
        {
            get
            {
                return 3;
            }
        }
        public static string Myname(string i)//靜態方法
        {
            return "123";
        }
        ~ClsBanking()//解構子
        {
            //MessageBox.Show("記憶體回收");
        }
        public void Disposed()
        {
            //釋放資源
        }
    }
}
