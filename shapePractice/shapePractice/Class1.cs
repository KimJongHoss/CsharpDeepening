using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapePractice
{
    public class shape
    {
        public string getShape() => "shape\r\n";
    }

    public class circle : shape
    {
        public string getShape() => "circle\r\n";
    }

    public class triangle : shape 
    {
        public string getShape() => "triangle\r\n";
    }

    public class square : shape
    {
        public string getShape() => "square\r\n";
    }
}
