using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_2testIndexer
{
    class Z                                   //这是一个能容纳100个整数的集合
    {
        private long[] arr = new long[100];   //声明一个私有数组成员
        public long this[int index]           //声明索引器
        {
            get
            {
                if (index < 0 || index >= 100)
                    return arr[0];
                else
                    return arr[index];
            }
            set
            {
                if (index < 0 || index >= 100)
                    arr[0] = value;
                else
                    arr[index] = value;
            }
        }
        public long Pow(int x, int y)         //计算x的y次方
        {
            return (long)Math.Pow(x, y);
        }
    }
    public class TestIndexer
    {
        static void Main()
        {
            Z z = new Z();                  //创建整数集对象
            for (int i = 0; i < 100; i++)   //计算1到100这100个数字的3次方
            {
                z[i] = z.Pow(i + 1, 3);       //把计算结果通过索引器赋值给相应数组元素
            }
            
            Console.WriteLine("1到100间的整数的3次方值依次如下：");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0}\t", z[i]); //通过索引器逐个输出数组元素的值
            }
            Console.ReadKey();
        }
    }

}
