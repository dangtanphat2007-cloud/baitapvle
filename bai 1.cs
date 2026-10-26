using System;

namespace Lab01_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.Clear();
                Console.WriteLine("================ LAB 01 - CONSOLE ================");
                Console.WriteLine("1. Bài tập 1: Nhập - Xuất tên");
                Console.WriteLine("2. Bài tập 2: Giải phương trình bậc 1 (Rẽ nhánh & Chuyển đổi kiểu)");
                Console.WriteLine("3. Bài tập 3: Mảng số nguyên (Tổng, Max, Min)");
                Console.WriteLine("4. Bài tập 4: Xử lý chuỗi (Nhập, Tách và Chuẩn hóa họ tên)");
                Console.WriteLine("0. Thoát");
                Console.Write("Mời bạn chọn bài tập (0-4): ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    chon = -1;
                }

                Console.WriteLine();
                switch (chon)
                {
                    case 1:
                        ChuyenBaiTap1();
                        break;
                    case 2:
                        ChuyenBaiTap2();
                        break;
                    case 3:
                        ChuyenBaiTap3();
                        break;
                    case 4:
                        ChuyenBaiTap4();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                        break;
                }

                if (chon != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }

            } while (chon != 0);
        }

        // Bài tập 1: Nhập - Xuất
        static void ChuyenBaiTap1()
        {
            Console.WriteLine("--- BÀI TẬP 1: NHẬP - XUẤT ---");
            Console.Write("Nhap vao ten ban: ");[cite: 1]
            string ten = Console.ReadLine();[cite: 1]
            Console.Write("Xin chao " + ten);[cite: 1]
            Console.WriteLine();
        }

        // Bài tập 2: Rẽ nhánh, Chuyển đổi kiểu dữ liệu
        static void ChuyenBaiTap2()
        {
            Console.WriteLine("--- BÀI TẬP 2: GIẢI PHƯƠNG TRÌNH BẬC 1 (ax + b = 0) ---");
            double a, b;

            // Sử dụng TryParse để khắc phục lỗi nhập liệu không hợp lệ theo gợi ý trong tài liệu
            Console.Write("Nhap tham so a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Giá trị không hợp lệ. Nhập lại tham số a: ");
            }

            Console.Write("Nhap tham so b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Giá trị không hợp lệ. Nhập lại tham số b: ");
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh co vo so nghiem");[cite: 2]
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem");[cite: 2]
                }
            }
            else
            {
                double x = -b / a;
                Console.Write("Phuong trinh co nghiem x= " + x.ToString());[cite: 2]
            }
            Console.WriteLine();
        }

        // Bài tập 3: Mảng (Tính tổng, lớn nhất, nhỏ nhất)
        static void ChuyenBaiTap3()
        {
            Console.WriteLine("--- BÀI TẬP 3: MẢNG SỐ NGUYÊN ---");
            Console.Write("Nhap so luong phan tu: ");[cite: 3]
            int n = int.Parse(Console.ReadLine());[cite: 3]
            int[] mang = new int[n];[cite: 3]

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i.ToString() + " :");[cite: 3]
                mang[i] = int.Parse(Console.ReadLine());[cite: 3]
            }

            // Tính tổng mảng
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += mang[i];[cite: 3]
            }
            Console.WriteLine("Tong cua mang la: " + tong.ToString());[cite: 3]

            // Tìm giá trị lớn nhất và nhỏ nhất (Bổ sung phần tự thực hiện theo yêu cầu tài liệu)
            if (n > 0)
            {
                int max = mang[0];
                int min = mang[0];
                for (int i = 1; i < n; i++)
                {
                    if (mang[i] > max) max = mang[i];
                    if (mang[i] < min) min = mang[i];
                }
                Console.WriteLine("So nguyen lon nhat trong mang la: " + max);
                Console.WriteLine("So nguyen nho nhat trong mang la: " + min);
            }
        }

        // Bài tập 4: Chuỗi
        static void ChuyenBaiTap4()
        {
            Console.WriteLine("--- BÀI TẬP 4: XỬ LÝ CHUỖI ---");
            Console.WriteLine("1. Xuất họ tên đầy đủ từ họ, tên lót, tên");
            Console.WriteLine("2. Tách họ tên đầy đủ thành từng phần");
            Console.WriteLine("3. Chuẩn hóa họ tên (viết hoa chữ cái đầu, xóa khoảng trắng thừa)");
            Console.Write("Chọn chức năng chuỗi (1-3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Nhap ho: ");[cite: 4]
                string ho = Console.ReadLine();[cite: 4]
                Console.Write("Nhap ten lot: ");[cite: 4]
                string tenlot = Console.ReadLine();[cite: 4]
                Console.Write("Nhap ten: ");[cite: 4]
                string ten = Console.ReadLine();[cite: 4]
                Console.WriteLine("Ho va ten day du: {0} {1} {2}", ho, tenlot, ten);[cite: 4]
            }
            else if (choice == "2")
            {
                Console.Write("Nhap ho ten day du: ");[cite: 4]
                string fullname = Console.ReadLine();[cite: 4]
                string SPACE = " ";
                string[] parts = fullname.Split(new string[] { SPACE }, StringSplitOptions.None);[cite: 4]
                if (parts.Length >= 3)
                {
                    Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);[cite: 4]
                }
                else
                {
                    Console.WriteLine("Chuỗi nhập vào không đủ 3 phần (Họ, tên lót, tên).");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Nhap ho ten (khong can theo chuan): ");[cite: 5]
                string fullname = Console.ReadLine();[cite: 5]
                string SEPERATOR = " ";
                string[] parts = fullname.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);[cite: 5]
                
                if (parts.Length >= 3)
                {
                    string ho = parts[0].Substring(0, 1).ToUpper() + parts[0].Substring(1, parts[0].Length - 1).ToLower();[cite: 5]
                    string tenlot = parts[1].Substring(0, 1).ToUpper() + parts[1].Substring(1, parts[1].Length - 1).ToLower();[cite: 5]
                    string ten = parts[2].Substring(0, 1).ToUpper() + parts[2].Substring(1, parts[2].Length - 1).ToLower();[cite: 5]
                    Console.WriteLine("Ten theo dung chuan la: {0} {1} {2}", ho, tenlot, ten);[cite: 5]
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập đầy đủ ít nhất 3 từ (Họ, tên lót, tên).");
                }
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
            }
        }
    }
}
