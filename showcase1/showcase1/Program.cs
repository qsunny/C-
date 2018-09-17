using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.aaron
{
    class Rectangle {
        double length;
        double width;
        public void acceptDetails() {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ShowCase1
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.acceptDetails();
            r.Display();
            Console.WriteLine("Size of double: {0}", sizeof(double));
            //动态（Dynamic）类型 定义
            dynamic d = 20;
            String str = "runoob.com";
            //等价于 string str = "C:\\Windows";
            string str2 = @"C:\Windows";
            int i = 75;
            float f = 53.005f;
            double dd = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(dd.ToString());
            Console.WriteLine(b.ToString());

            const double pi = 3.14159; // 常量声明


            Console.ReadLine();
        }
    }
}
