using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_29_9_.Model
{
    public class POINT
    {
        public int x;
        public int y;
      public POINT(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public POINT()
        {

        }
        ~POINT()
        {

        }
        public POINT input()
        {
            POINT p = new POINT();
            Console.WriteLine("Input x: ");
            p.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y: ");
            p.y = Convert.ToInt32(Console.ReadLine());
            return p;
        }
        public  void outPut()
        {

        }
    }
}
