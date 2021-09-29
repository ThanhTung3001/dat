using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_29_9_.Model
{
    public class RECTANGLE: SHAPE
    {
        public double length, width;
       public RECTANGLE(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        ~RECTANGLE()
        {

        }
        public RECTANGLE()
        {

        }
        public override void input()
        {
            Console.WriteLine("length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("width");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public override void outPut()
        {
            Console.WriteLine("length:{0}",length) ;
            Console.WriteLine("width:{0}",width);
           
        }
        public override double area()
        {
            return (double)length * width;
        }
    }
}
