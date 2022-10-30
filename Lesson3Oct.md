# Lesson 3 (October 29, 2022), 7h10-9h10

- Tính đóng gói (Encapsulation):
    + Khả năng che giấu thông tin bằng cách sử dụng các chỉ thị truy cập
    + Public: bất kì thành phần nào cũng có thể truy cập bên ngoài lớp
    + Private: chỉ có thể truy cập trong phạm vi cục bộ
    + Protected: chỉ có thể được truy cập thông qua việc kế thừa
    + Internal: có thể được truy cập bởi tất cả các lớp cùng 1 assembly 
    + Protected Internal: Protected + Internal
- Tính kế thừa (Inheritance):
    + Lớp 'dẫn xuất' được kế thừa có thể sử dụng variables và method của lớp 'cơ sở'
    + Các thành viên không được kế thừa: 
        .Static constructor
        .Instance constructor
        .Destructor
    + Có thể kế thừa 1 lớp và triển khai (implement) nhiều *interface
        *interface: interface trong c# đc coi như 1 "bản hợp đồng" mô tả những gì cần phải làm mà các lớp thực thi interface phải tuân theo, interface trong c# là 1 công cụ mạnh giúp tạo ra mối quan hệ lỏng giữa các lớp, qua đó giúp phát triển và test các thành phần một cách độc lập
        *+ interface là một kiểu dữ liệu tương tự class nhưng chỉ đưa ra mô tả của các thành viên mà không đưa ra phần thực thi, phần thân của các phương thức sẽ được xây dựng trong các class thực thi interface này
        *+ cũng giống như abstract class, interface không dùng để khởi tạo object mà dùng để các lớp cụ thể kế thừa, khi một class kế thừa từ một interface, nó bắt buộc phải cung cấp phần thực thi cho tất cả các thành viên của interface
        *! interface dùng để định nghĩa cho class
- Tính đa hình (Polymorphism):
    + Đa hình tĩnh (overloading): Có thể nạp chồng phương thức bằng cách tạo nhiều phương thức cùng tên nhưng có thể khác nhau về kiểu dữ liệu hoặc số lượng params
        * Nạp chồng toán tử
        * không thể nạp chồng phương thức khi các đối tượng chỉ khác nhau kiểu trả về
    + Đa hình động (overriding): 
- Tính trừu tượng (Abstraction): 