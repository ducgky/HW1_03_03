using System;
using System.Diagnostics.CodeAnalysis;

namespace Question_1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //B1_Nhập số từ bàn phím
            Console.WriteLine("Nhập Số Thứ Nhất:  ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhập Số Thứ Hai:  ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //B2_Tính Toán Giá Trị 
            double sum = number1 + number2;
            double different = number1 - number2;
            double product = number1 * number2;

            Console.WriteLine("Kết quả của tổng là " + sum);
            Console.WriteLine("Kết quả của hiệu là " + different);
            Console.WriteLine("Kết quả của nhân là " + product);

            //Kết Thúc
            Console.WriteLine("Thoát Phép Tính");
            Console.ReadKey();

        }
    }
}
