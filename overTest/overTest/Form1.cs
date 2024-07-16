using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //M0 m0 = new M0();

            //textBox1.Text = m0.GetNumber(10).ToString()+"\r\n";
            //textBox1.Text += m0.GetNumber(10, 20).ToString() + "\r\n";
            //textBox1.Text += m0.GetNumber((long)100).ToString();

            Square square = new Square();

            textBox1.Text += square.Say();
            textBox1.Text += square.Go();
            textBox1.Text += square.getShape();

            Shape shape = new Shape();
            textBox1.Text += shape.Say();
            textBox1.Text += shape.Go();
            textBox1.Text += shape.getShape();

        }

       

    }
}
