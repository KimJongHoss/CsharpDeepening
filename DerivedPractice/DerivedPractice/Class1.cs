using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerivedPractice
{
    public class Shape
    {
        protected string getShape() => "Shape";
        public string getShape2() => "Shape2(public)";
        private string getShape3() => "Shape3(private)";
        internal string getShape4() => "Shape4";
    }

    public class Square : Shape
    {
        public Square() => MessageBox.Show(getShape());
        
        void test()
        {
            
        }
    }
}
