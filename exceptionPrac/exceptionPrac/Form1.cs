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

namespace exceptionPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string content = File.ReadAllText(@"C:\KJH\CsharpDeepening\exceptionPrac\test.txt");//@ : 여기에 있는 \는 탈출문자가 아니다를 의미
            string content = File.ReadAllText("test.txt");
            textBox1.Text = content;

            string a = "\""; //\뒤에 있는 "는 실제 문제 "임을 나타냄 \:탈출문자
        }
    }
}
