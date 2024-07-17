using System;
namespace CSharp_TinhLuyThua
{
    class Program()
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Chương trình tính giai thừa của một số");
            int a, b;
            Console.Write("Nhập số: ");a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập mũ: ");b = Convert.ToInt32(Console.ReadLine());
            TinhGT(a, b);
        }
        static void TinhGT (int x, int y)
        {
            int ketqua;
            ketqua = 1;
            if (y < 0) Console.WriteLine("Số mũ phải lớn hơn 0");
            else if (y == 0) Console.WriteLine("Kết quả của chương trình bằng 1");
            else
            {
                for (int i = 1; i <= y; i++)
                {
                    ketqua *= x;
                }
            }
            Console.WriteLine($"Kết quả của chương trình là: {ketqua}");

        }
    }
}
