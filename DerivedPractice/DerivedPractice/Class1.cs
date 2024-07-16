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
    }

    public class Square : Shape
    {
        public Square() => MessageBox.Show(getShape());
        
    }
}
