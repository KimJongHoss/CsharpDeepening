using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stackTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Stack stack = new Stack();

            //stack.Push("일");
            //stack.Push("이");
            //stack.Push("삼");

            //try
            //{
            //    int stack_size = stack.Count;
            //    for (int i = 0; i < stack_size+1; i++)
            //    {
            //        textBox1.Text += $"{stack.Peek()}\r\n";
            //        textBox1.Text += $"{stack.Pop()}\r\n";
            //    }

            //}
            //catch (Exception e)
            //{
            //    textBox1.Text += e.Message;
            //}

            printP(1);
        
    }
        //[보너스 문제] 삼 이 일 출력하는 기능을 재귀함수로 구현
   

    void printP(int c)
    {
        if (c == 4) { return; }
        printP(c + 1);
        switch (c)
        {
            case 1:
                textBox1.Text += "일\r\n";
                break;
            case 2:
                textBox1.Text += "이\r\n";
                break;
            case 3:
                textBox1.Text += "삼\r\n";
                break;
        }
    }

}
}
