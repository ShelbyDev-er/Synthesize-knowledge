# Lesson 1 (October 23, 2022), 9h - 11h
- Các loại website:
    + Web APIs: web sử dụng API
    + Web App: là web sử dụng html, css, và js thuần 
    + realtime:-ex: dự báo thời tiêt, theo dõi chỉ số chứng khoán app, chuyển khoản app;...
    + MicroService: có thể sử dụng nhiều công nghệ khác nhau trong cùng 1 dự án
- Tổng quát về .net:
    + là 1 công nghệ được phát triển bởi Microsoft
    + là một nền tảng phát triển phần mềm giúp tạo ra các ứng dụng chạy trên windows
    + mang tính bảo mật cao (mô hình bảo mật Evidence - based)
- Khái niệm boxing, unboxing:
    + boxing: sau khởi tạo 1 biến có kiểu dữ liệu obj toàn bộ dữ liệu trong obj đó được cất vào 1 nơi trong bộ nhớ, không thể thấy được các dữ liệu trong biến đó trừ khi ta 'unboxing-truy cập và sử dụng dữ liệu trong obj đó'  
- Biến và kiểu dữ liệu trong c#:
    + Các kiểu dữ liệu hay sử dụng: int, float, double, string, char, bool, byte
        & byte: số nguyên (0 - 200+)
        & int: số nguyên (0 - 2 tỉ)
        & float: số thực (32 bit)
        & double: số thực (64 bit)
        & string: chuỗi kí tự
        & char: 1 kí tự
        & bool: true, false
            * Gán 1 biến có kiểu dữ liệu lớn hơn vào biến có kiểu dữ liệu nhỏ hơn ? false : true
- Tham trị, tham chiếu:
    + Tham trị: khi tạo ra một biến, 1 ô nhớ được tạo ra và ta có thể truy cập vào dữ liệu trong ô nhớ đó thông qua "địa chỉ - tên biến", có thể ghi đè
    + Tham chiếu: khi tạo ra một biến, 1 địa chi ô nhớ được tạo ra và "địa chỉ - tên biến" đó trỏ tới giá trị của biến, khi gán giá trị mới cho biến sẽ copy lại 1 địa chỉ ô nhớ mới và không làm ảnh hưởng tới giá trị được tạo trước đó

# Lesson 2 (October 28, 2022), 7h10-9h10

=======================================================================================================================================
                                                            Training
=======================================================================================================================================
- Nhập xuất:
    + Console.Write();
    + Console.WriteLine();
    + Console.Read(); đọc 1 kí tự từ bán phím sau đó in ra kí tự vừa đọc
    + Console.ReadKey(); if false: ko xuất input ra màn hình, elif true: xuất input ra màn hình, else không truyền tham số mặc định là false (có thể dùng khi muốn mất đi dòng chữ press any key to continue)
    + Console.ReadLine(); đọc dữ liệu input (có thể dùng khi muốn mất đi dòng chữ press any key to continue)
- Biến trong C#:
    + Khi tạo ra một biến, biến đó được tham chiếu đến 1 địa chỉ ô nhớ trong vùng nhớ thay vì dùng "địa chỉ" của ô nhớ đó
- Hằng (like const)
    Ex: const int x = 10;
- Object trong C#:
    + objName.Equals: So sánh 2 đối tượng có bằng nhau k, return bool
    + objName.GetHashCode: Trả về mã của đối tượng 
    + objName.GetType 
    + objName.ToString 
    + Boxing: chuyển từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu
        Ex: int value = 10; object objectValue = value;
        objectValue tham chiếu tới giá trị value
    + Unboxing:
        Ex: int newValue = (int)objectValue;
- Kiểu dữ liệu dynamic:
    + Kiểu dữ liệu dynamic không được xác định cho đến khi chương trình chạy
- Cấu trúc lặp "goto":
        Ex: goto MyHome (tạo biến dịch chuyển code); console.Write('Your Home'); MyHome  (điểm dịch chuyển code); console.Write('MyHome'); =>>>>>>>> result = MyHome
        ====================================================
        int a = 2;
        switch(a)
        {
            case 1: 
                Console.Write("case 1");
                break;
            case 2:
                Console.Write("case 2");
                goto case 1;
                <!-- break; -->
            ...
        }
        result = case 2case 1
        ====================================================
        firstPoint:
        goto secondPoint;
        secondPoint:
        goto firstPoint;
- Biến toàn cục và biến cục bộ:
        Ex: 
        class Program
        {
            static int value = 5;
            static void Main(string[] args)
            {
                Console.WriteLine(value);
                PrintSomeThing();
                Console.ReadLine();
            }
            static void PrintSomeThing()
            {
                int value = 9; (biến cục bộ)
                Console.WriteLine(value);
            }
        }
        * value là biến toàn cục của hàm Main và hàm PrintSomeThing
        * value là biến cục bộ của class Program 
- Từ khóa ref và out:
        ref Ex:
        class Program
        {
            static void Main(string[] args) 
            {
                int value = 5;
                Console.WriteLine("Value before increase: {0}");
                IncreaseValue(ref value);
                Console.WriteLine("Value after increase: {0}");
                Console.ReadLine();
            }
            static void IncreaseValue(ref int value)
            {
                value++;
            }
        }
        out Ex:
        class Program
        {
            static void Main(string[] args)
            {
                int value = 5;
                Console.WriteLine("Value before increase: {0}");
                IncreaseValue(out value);
                Console.WriteLine("Value after increase: {0}");
                Console.ReadLine();
            }
            static void IncreaseValue(out int value)
            {
                value++;
            }
        }
- Phạm vi truy cập:
    Public: Có thể truy cập từ toàn bộ các file
    Private: (Mặc định) Chỉ Truy cập trong phạm vi của biến được khai báo
- Mảng một chiều:
    Ex:
        Khai báo mảng một chiều kiểu string có tên là KTeam:

    string[] Kteam = new string[] { "HowKteam", "Free Education" };

    int[] IntArray = { 3, 9, 10 };

    Console.WriteLine(Kteam[1]);
    Ex2: 
    int Year;
    string[] Can = {"Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky"};
    string[] Chi = {"Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui"};
    Console.Write("Moi ban nhap mot nam bat ky: ");
    Year = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year % 10], Chi[Year % 12])
- Mảng 2 chiều: 
    Ex: khai báo mảng hai chiều Array, truy xuất = Array[0, 3]; trong đó 2 là chỉ số của các array và 3 là chỉ số của phần tử trong mảng 
    string[,] Array = {
        {1, 2, 3, 4, 5, 6},
        {7, 8, 9, 10, 11, 12},
        ...
    }
    Array.Rank trả về số chiều của mảng
- Mảng đa chiều:
    Ex:
    int[,,] intArray;
    double[,,] dArray = new double[6, 9, 10];
    float[,,] fArray = new float[,,]
        {
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8}
            },
            {
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            }
        }
- Mảng ziczac:
    Ex: 
    int[][] intArray;
    double[][] dArray = new double[6][];
    dArray[0] = new double[9];
    dArray[1] = new double[10];

    float[][] fArray =
    {
        new float[] {1, 2, 3},
        new float[] {4, 5, 6, 7, 8, 9}
    }
- Array List:
    + ToString()
    + Count()
    + Add()
    + AddRange()
    + Clone()
    + Clear()
    + Contains
    + BinarySearch() !
<!-- - Hashtable:
- SortedList:
- Stack:
- Queue:
- Generic:
- List:
- Dictionary:
- Tuple:  -->
=======================================================================================================================================
