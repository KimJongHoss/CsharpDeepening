using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overTest
{
    internal class M0
    {

        public int GetNumber(int n) => n;

        public int GetNumber(int n1, int n2) => n1+n2;

        public long GetNumber(long n) => n-99;

    }

    public class Shape
    {
        public string Say() => "Hi\r\n";
        public string Go() => "Go\r\n";
        public virtual string getShape() => "Shape\r\n";
    }

    public class Square : Shape
    {
        public string Say() => "Hello\r\n";
        public string Go() => "GoGoGo\r\n";
        public override string getShape() => "Square\r\n";
    }

}
