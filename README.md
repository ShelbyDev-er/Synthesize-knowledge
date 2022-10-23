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
    + Tham chiếu: khi tạo ra một biến, 1 địa chi ô nhớ được tạo ra và "địa chỉ - tên biến" đó trỏ tới giá trị của biến, ghi đè sẽ copy lại 1 địa chỉ ô nhớ mới và không làm ảnh hưởng tới giá trị tại lần khởi tạo trước