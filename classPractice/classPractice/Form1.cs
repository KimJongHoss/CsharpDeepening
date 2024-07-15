using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classPractice
{
    public partial class Form1 : Form
    {
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        public int Num
        {
            get { return Num; }
            set { Num = value; }
        }

        public decimal Money
        {
            get => Money; 
            set => Money = value;
        }


        public Form1()
        {
            InitializeComponent();

            //int a;

            //Square square = new Square();
            //textBox1.Text = square.GetName();

            //Square square = new Square("생성자 야호!");
            { 
                Square square = new Square();
                //~Square(); 이렇게 부를수는 없다.
            }
        }
        ~Form1() 
        {
            MessageBox.Show("Form1 소멸자");//폼이 하나밖에 없어서 호출 안됨
        }
    }
}
