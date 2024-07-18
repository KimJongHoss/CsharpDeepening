using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queueTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            try
            {
                int queue_size = queue.Count;
                for (int i = 0; i < queue_size + 1; i++)
                {
                    textBox1.Text += $"{queue.Dequeue()}\r\n";
                }
            }
            catch (Exception e)
            {
                textBox1.Text += e.Message;
            }

        }
    }
}
