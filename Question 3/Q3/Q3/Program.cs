using System;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                //Bắt đầu định nghĩa giá trị nhiệt độ
                double c, k, f;

                //Nhập độ C để đổi sang F và K
                Console.WriteLine(" Nhiệt Độ C:");
                c = float.Parse(Console.ReadLine());

                //Tính Toán Đổi Độ C
                k = c + 237.15 ;

                f = (c * (1.8)) + 32;
                //Hiển Thị
                Console.WriteLine("Nhiệt Độ K Là: {0} ", k);
                Console.WriteLine("Nhiệt Độ F Là: {0}  ", f);

                Console.ReadLine();

                break;
            }
            


        }
    }
}
