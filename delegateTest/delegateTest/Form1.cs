using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegateTest
{
    public partial class Form1 : Form
    {

        //void Hi() => textBox1.Text += "Hi\r\n";
        //delegate void CallDelegate(); //함수를 변수처럼 선언

        //internal class Tank
        //{
        //    public string result { get; set; } = string.Empty;
        //    public void Forward(int Length) => result += $"{Length}만큼 전진\r\n";
        //    public void Backward(int Length) => result += $"{Length}만큼 후진\r\n";
        //    public void Rotate(int angle) => result += $"{angle}도만큼 회전\r\n";
        //}

        //delegate void Move(int value);

        delegate void Runner();

        void RunnerCall(Runner runner) => runner();
        void Run() => textBox1.Text += "달려!!\r\n";
        void Stop() => textBox1.Text += "멈춰!!!\r\n";
        void Walk() => textBox1.Text += "걷자~~\r\n";
        int Go() => 1;
        void Go2(int a) => textBox1.Text += a+"만큼 가보자~";

        public Form1()
        {
            InitializeComponent();

            //CallDelegate callDelegate = new CallDelegate(Hi); //함수를 변수처럼 호출
            //callDelegate();
            //callDelegate.Invoke();

            //Tank tank = new Tank();

            //Move move;
            //move = tank.Forward;
            //move += tank.Backward;
            //move += tank.Rotate;

            //move -= tank.Rotate;
            //move(20);

            //textBox1.Text += tank.result;

            Runner runner = new Runner(Run);
            RunnerCall(runner);
            RunnerCall(new Runner(Stop));
            RunnerCall(new Runner(Walk));
            RunnerCall(Stop);
            RunnerCall(()=>textBox1.Text += "익명\r\n");
            //RunnerCall(Go); // 타입이 void가 아니라서 안됨
            //RunnerCall(Go2); // void이지만 인자가 있어서 안됨

        }
    }
}
