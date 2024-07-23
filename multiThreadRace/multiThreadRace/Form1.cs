using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiThreadRace
{
    public partial class Form1 : Form
    {

        int[] carLength = new int[5];
        bool[] carStop = new bool[5];
        static object lockObject = new object();
        Stopwatch stopwatch;
        Thread[] carThreads;
        private static Random rd = new Random();
        void RandomSleep()
        {
            int sleepTime = (int)(rd.NextDouble() * 1000.0);
            Thread.Sleep(sleepTime);
            Console.WriteLine("자고 있어요.." + sleepTime);
        }
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch(); // Stopwatch 객체 초기화


            carThreads = new Thread[5];
            
        }

       

        void driveCar(int index)
        {
            Console.WriteLine("index : "+index);
            long startTime = stopwatch.ElapsedMilliseconds; // 시작 시점 기록
            while (!carStop[index])
            {
                carLength[index]++;
                if (carLength[index] == 10)
                {
                    carStop[index] = true;
                    long arriveTime = stopwatch.ElapsedMilliseconds - startTime; // 상대적인 시간 계산

                    //if (this.IsDisposed || textBox1.IsDisposed) return; // 폼 또는 컨트롤이 삭제된 경우 종료
                    if (textBox1.InvokeRequired)
                    {
                        textBox1.Invoke(new MethodInvoker(() =>
                        {
                            //if (this.IsDisposed || textBox1.IsDisposed) return; // 이미 삭제된 경우 무시
                            textBox1.Text += $"{index + 1}번 차량 도착! 도착 시간: {arriveTime} ms\r\n\r\n";

                        }));
                    }
                    else
                    {
                        textBox1.Text += $"{index + 1}번 차량 도착! 도착 시간: {arriveTime} ms\r\n\r\n";

                    }
                }

                for (int i = 0; i < 5; i++) 
                {
                    Console.WriteLine("carLength["+i+ "] : " + carLength[i]);
                }

                RandomSleep();
            }
        }

       
        private void raceButton_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("레이스 시작!\r\n");
            stopwatch.Restart(); // Stopwatch 시작

            lock (lockObject)//racing condition(레이스 하듯이)를 방지
            {
                for (int i = 0; i < 5; i++)
                {
                    int index = i; // 클로저 문제 해결을 위해 로컬 변수 사용
                    carThreads[i] = new Thread(() => driveCar(index));
                    carThreads[i].Start();
                    textBox1.Text += i + 1 + "번 차가 출발하였습니다.\r\n";
                }
              
            }

            //foreach (var carThread in carThreads)
            //{
            //    carThread.Join(); //start하고 join하면 해당 스레드가 끝날때까지 기다렸다가 다음꺼 진행
            //}

        }
    }
}
