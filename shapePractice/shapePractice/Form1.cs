using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            circle circle = new circle();
            circle circle1 = new circle();
            circle circle2 = new circle();
            triangle triangle = new triangle();
            triangle triangle1 = new triangle();
            triangle triangle2 = new triangle();
            square square = new square();
            square square1 = new square();
            square square2 = new square();
            square square3 = new square();

            textBox1.Text += square.getShape();
            textBox1.Text += circle.getShape();
            textBox1.Text += square1.getShape();
            textBox1.Text += triangle.getShape();
            textBox1.Text += square2.getShape();
            textBox1.Text += circle1.getShape();
            textBox1.Text += triangle1.getShape();
            textBox1.Text += square3.getShape();
            textBox1.Text += triangle2.getShape();
            textBox1.Text += circle2.getShape();

        }
    }
}
