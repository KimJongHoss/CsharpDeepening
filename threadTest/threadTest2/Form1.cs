using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadTest2
{
    public partial class Form1 : Form
    {

        static int sharedData = 0;
        static object lockObject = new object();

        public Form1()
        {
            InitializeComponent();

            //textBox1.Text += "1번 스레드 시작!\r\n";

            //var new_thread = new Thread(new ThreadStart(MyThread));
            //new_thread.Start();

            //textBox1.Text += "1번 스레드 끝1\r\n";

            Thread thread1 = new Thread(UpdateDate1);
            Thread thread2 = new Thread(UpdateDate2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        private void UpdateDate1()
        {
            lock (lockObject) // 자물쇠 걸어놓듯이 이 안에서 작업이 끝나고 다른 곳으로 갈 수 있게 강제할 수 있다 -> 실행순서 보장
            {
                for (int i = 0; i < 10; i++)
                {
                
                    sharedData++;
                    Thread.Sleep(10);
                    textBox1.Text += $"1: " + sharedData + "\r\n";
                }
                
            }
        }

        private void UpdateDate2()
        {
            lock (lockObject)
            {
                for (int i = 0; i < 10; i++)
                {
                
                    sharedData++;
                    Thread.Sleep(10);
                    textBox1.Text += $"2: " + sharedData + "\r\n";
                }
            }
        }


        //private void MyThread()
        //{
        //    textBox1.Text += "2번 스레드 시작! \r\n";

        //    Thread.Sleep(1000);

        //    textBox1.Text += "2번 스레드 끝!\r\n";
        //}
    }
}
