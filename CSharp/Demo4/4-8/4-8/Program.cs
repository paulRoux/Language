using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_8
{
    public delegate void Caculate(int x, int y);  //声明委托
    public class CaculateOfNumber                //声明类
    {
        public Caculate handler;  //这是一个委托型的字段

        public void Product(int x, int y)
        {
            Console.WriteLine("{0}与{1}的乘积为{2}", x, y, x * y);
        }
        public void Average(int x, int y)
        {
            Console.WriteLine("{0}与{1}的平均值为{2}", x, y, (x + y) / 2);
        }
        public void Pow(int x, int y)
        {
            Console.WriteLine("{0}的{1}次方值为{2}", x, y, (int)Math.Pow(x, y));
        }
    }

    public class TestDelegate
    {
        static void Main()
        {
            int a = 5, b = 6;
            CaculateOfNumber cn = new CaculateOfNumber();   //创建一个对象

            //使用多路广播机制来创建委托调用列表         
            cn.handler = new Caculate(cn.Product);
            cn.handler += new Caculate(cn.Average);
            cn.handler += new Caculate(cn.Pow);

            //一次性调用上面指定的方法
            cn.handler(a, b);

            Console.ReadKey();
        }
    }

}
