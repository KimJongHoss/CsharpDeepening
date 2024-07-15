using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryPractice;

namespace structPractice
{

    struct Point
    {
        public int x; 
        public int y;
        public int z;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Point p = new Point();

            //p.x = 13;
            //p.y = 21;
            //p.z = -4;

            //textBox1.Text = $"point({p.x}, {p.y}, {p.z})";

            //Point[] p = new Point[3];

            //for (int i = 0; i < p.Length; i++)
            //{
            //    p[i].x = i;
            //    p[i].y = i * i;
            //    p[i].z = -i;

            //    textBox1.Text += $"point({p[i].x}, {p[i].y} ,  {p[i].z})\r\n";

            //}

            Hi();
            textBox1.Text += Add(4, 2).ToString();

            Class1 class1 = new Class1();
            class1.a = 1;
            class1.b = 2;

        }

        void Hi() => textBox1.Text += "Hi\r\n";

        int Add(int a, int b) => a + b; //arrow 함수는 마지막 줄이 return된다.

       
        
        

    }
}
