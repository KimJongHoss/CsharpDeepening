using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashTableTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //해시테이블을 사용하는 이유
            //빠른 검색을 위해
            //가장빠름

            Hashtable hashtable = new Hashtable();

            hashtable[0] = 999; // 0번째 인덱스를 의미하는 것이 아닌 그저 key-value일 뿐이다.
            hashtable["이름"] = "홍길동";
            hashtable["취미"] = "코딩";

            textBox1.Text += $"{hashtable[0].ToString()}\r\n";
            textBox1.Text += $"{hashtable["이름"]}\r\n";
            textBox1.Text += $"{hashtable["취미"]}\r\n";


        }
    }
}
