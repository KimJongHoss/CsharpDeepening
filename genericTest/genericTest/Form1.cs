using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genericTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //stack&list
            //Stack<int> i_stack = new Stack<int>();
            //i_stack.Push(1);
            //int num = i_stack.Pop();
            //textBox1.Text += i_stack.Count + "\r\n";
            //textBox1.Text += num + "\r\n";

            //List<double> d_list = new List<double>();
            //d_list.Add(30.409f);
            //d_list.Add(329.329f);

            //foreach (double d in d_list)
            //{
            //    textBox1.Text += $"{d}\r\n";
            //}

            // 열거형
            //int size = 10;
            //var numbers = Enumerable.Range(1, size);
            //var same_numbers = Enumerable.Repeat(0,size);

            //textBox1.Text += $"{numbers}\r\n";
            //textBox1.Text += $"{same_numbers}\r\n";

            //foreach (var number in numbers)
            //{
            //    textBox1 .Text += $"{number}" ;
            //}
            //textBox1.Text += "\r\n";
            //foreach (var number in same_numbers)
            //{
            //    textBox1.Text += $"{number}";
            //}

            //딕셔너리
            //사용법 1
            IDictionary<string, string> data1 = new Dictionary<string, string>();
            //사용법 2
            var data2 = new Dictionary<string, string>();

            //데이터 추가
            data1.Add("오리온", "고래밥");
            data2.Add("농심","신라면레드");

            //데이터 제거 및 변경
            data1.Remove("오리온");
            data2["농심"] = "볶음너구리";

            // TextBox에 출력
            textBox1.Text += "data1:\n\r";
            foreach (var item in data1)
            {
                textBox1.Text += $"{item.Key}: {item.Value}\n\r";
            }

            textBox1.Text += "\ndata2:\n\r";
            foreach (var item in data2)
            {
                textBox1.Text += $"{item.Key}: {item.Value}\n\r";
            }

            try
            {
                data2.Add("농심", "짜파게티");
            }
            catch (Exception ex)
            { 
                textBox1.Text = ex.Message+"\r\n";
            }

           if(!data1.ContainsKey("오리온"))
            {
                data1.Add("오리온", "초코파이");
            }

           if(data1.TryGetValue("오리온", out string value))
            {
                textBox1.Text += $"{value}\r\n";
            }

            foreach (KeyValuePair<string, string> item in data1)
            {
                textBox1.Text += $"{item.Key}에서 {item.Value}를 만듭니다.\r\n";
            }
        }
    }
}
