using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newandoverride
{

    class Dad
      {
         public Dad()
         {
             Console.WriteLine("Dad construtor");
         }
         public virtual void method()
         {
             Console.WriteLine("Dad method");
         }
     }
     class SmallSon : Dad
    {
         public SmallSon()
         {
             Console.WriteLine("Smallson construtor");
        }
         public override void method()
        {
             Console.WriteLine("override Smallson method");
         }
     }
     class BigSon : Dad
     {
         public BigSon()
         {
             Console.WriteLine("BigSon construtor");
         }
         public new void method()
         {
             Console.WriteLine("new BigSon method ");
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
           
    
             Dad f = new Dad();
             Dad f1 = (Dad)new SmallSon();// 先初始化Dad(),然后再初始化SmallSon()
             f1.method();//override smallson method
             Dad f2 = (Dad)new BigSon();// 先初始化Dad(),然后再初始化Bigson()
             f2.method();// Dad method
             BigSon s = new BigSon();
             s.method();
             
         }
     }
 }
       
    
