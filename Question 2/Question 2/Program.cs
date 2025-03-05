using System;
using System.Diagnostics.Eventing.Reader;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                //Giải Phương Trình Bậc 2 Dạng ax^2+bx+c=0; các hệ số nhập là a,b,c
                float a, b, c;
                double x1, x2, delta;

                //Nhập hệ số a, b, c vào:

                Console.WriteLine("Hãy nhập vào 1 số a");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Hãy Nhập vào 1 số b");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Hãy Nhập vào 1 số c");
                c = float.Parse(Console.ReadLine());

                //Hiển thị phương trình gắn với dữ liệu vừa nhập:
                Console.WriteLine("Phương trình có dạng: {0}x^2+{1}x+{2} = 0 ", a,b,c);

                //Giải phương trình bậc 2:
                if (a == 0)  //khi a bằng 0
                {
                    //Nếu a bằng 0 giải phương trình bx+c=0
                    if (b == 0)
                    {
                        if (c == 0) //Nếu C bằng 0
                        {
                            Console.WriteLine("Phương Trình Có Vô Số Nghiệm Với Mọi X");
                        }
                        else //c khác 0
                        {
                            Console.WriteLine("Phương Trình Vô Nghiệm");
                        }
                    }
                    else // khi b khác 0
                    {
                        x1 = -c / b;
                        Console.WriteLine("Phương trình có 1 nghiệm duy nhất {}", x1);
                    }

                } 
                else
                {
                    //Sử dụng công thức tính delta
                    delta = (b *b) - (4 * a * c);
                    //Sau khi tính được delta sẽ đi kiểm tra nghiệm
                    if (delta < 0)
                    {
                        Console.WriteLine("Phương Trình Vô Nghiệm");
                    }
                    else if(delta == 0)
                    {
                        x1 = x2 = -b / (a +a);
                        Console.WriteLine("Phương trình có 1 nghiệm kép x1=x2 {}",x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt (delta)) / (a +a);
                        x2 = (-b - Math.Sqrt (delta)) / (a +a);
                        Console.WriteLine("Phương trình có 2 nghiệm là \n {0} = \n {1} =", x1,x2);
                    }

                }
                Console.ReadLine();  
               
           
            }
            
            

        }
    }
}
