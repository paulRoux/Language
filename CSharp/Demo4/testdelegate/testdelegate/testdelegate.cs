using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace testdelegate
{
    public delegate int Caculate(int x,int y);  //声明委托

    
    public class Caculateofnumber
    {
                    
            public Caculate handler;       //这是一个委托型的字段
            
            public int Product(int x,int y)
            {
                return x*y;
            }
            public int Average(int x,int y)
            {
                return (x + y) / 2;
            }
    }
   #region 委托测试类
    class testdelegate
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            Caculateofnumber cn = new Caculateofnumber();    //创建一个对象
            cn.handler = new Caculate(cn.Product);         //初始化委托型字段

            //通过委托来调用方法
            Console.WriteLine("{0}与{1}的乘积为{2}",a,b,cn.handler(a,b));
            cn.handler = new Caculate(cn.Average);
            Console.WriteLine("{0}与{1}的平均值为{2}", a, b, cn.handler(a, b));

            //使用匿名方法来初始化委托型字段
            cn.handler = delegate(int x, int y) { return (int)Math.Pow(x, y); };
            Console.WriteLine("{0}的{1}次方值为{2}",a,b,cn.handler(a,b));


            Console.ReadKey();
            
        }
    }
   #endregion
}
