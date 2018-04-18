using System;
using System.Collections;
//using System.Linq;
//using System.Text;

namespace _5_1test.queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(50, 3);
            q.Enqueue("11");
            q.Enqueue("22");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Console.ReadKey();
        }
    }
}
