using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace eventTest
{

   
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            button = new MyButton();

            button.Click += new MyButton.EventHandler(Hello);
            button.Click += new MyButton.EventHandler(Bye);

        }

        void Hello() => textBox1.Text += "Hello\r\n";
        void Bye() => textBox1.Text += "Bye\r\n";

        MyButton button;

        private void button1_Click(object sender, EventArgs e)
        {
            button.OnClick();
        }
    }



    internal class MyButton
    {
        public delegate void EventHandler();
        public event EventHandler Click;

        public void OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }

    }

    
}
