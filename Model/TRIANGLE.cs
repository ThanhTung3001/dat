using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_29_9_.Model
{
    public class TRIANGLE : SHAPE
    {
        public double bottonEdge, hieght;

        public TRIANGLE(double bottonEdge, double hieght)
        {
            this.bottonEdge = bottonEdge;
            this.hieght = hieght;
        }
        ~TRIANGLE(){

        }
        public override void input()
        {
            Console.WriteLine(" bottonEdge: ");
            bottonEdge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" hieght: ");
            hieght = Convert.ToDouble(Console.ReadLine());
        }
        public override void outPut()
        {
            Console.WriteLine(" bottonEdge: ", bottonEdge);
          
            Console.WriteLine(" hieght: ", hieght);
        }
        public override double area()
        {
            return ((double)bottonEdge * hieght) / 2;
        }
    }
}
