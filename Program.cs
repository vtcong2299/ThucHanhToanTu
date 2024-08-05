using System;


namespace THUCHANHTOANTU
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            int area;

            Console.WriteLine("Nhap chieu dai: ");
            height= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            width= Int32.Parse(Console.ReadLine());
            area= height*width;
            Console.WriteLine("Dien tich hinh chu nhat la: {0}", area);
            
        }
    }
}