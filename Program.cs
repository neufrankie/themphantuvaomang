using System;

namespace Themphantuvaomang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước
            int[] array = { 1, 3, 5, 7, 9 };

            // Bước 2: Nhập X là số cần chèn
            Console.Write("Nhap vao so can chen them: ");
            int X = int.Parse(Console.ReadLine());

            // Bước 3: Nhập vào vị trí index cần chèn X vào trong mảng
            Console.Write("Nhap vao vi tri ban muon chen: ");
            int index = int.Parse(Console.ReadLine());

            // Bước 4: Kiểm tra điều kiện và hiển thị thông báo nếu index không hợp lệ
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Khong chen duoc phan tu nay vao mang.");
                return;
            }

            // Bước 5: Thực hiện chèn phần tử X ở vị trí index vào mảng
            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = X;

            // Bước 6: In ra mảng
            Console.WriteLine("Mang sau khi chen:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
