Khổng Minh Hiếu-24810320250-D19QTANM1 
Câu 1: Phân biệt Value Types và Reference Types trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap) :
•	Vị trí lưu trữ vùng nhớ:
o	Value Types (Kiểu giá trị): Dữ liệu được lưu trữ trực tiếp trên vùng nhớ Stack. (Ngoại lệ: Nếu một biến kiểu giá trị là thuộc tính/field nằm bên trong một Class, nó sẽ nằm inline trên Heap cùng đối tượng đó).
o	Reference Types (Kiểu tham chiếu): Đối tượng dữ liệu thực tế được cấp phát trên Managed Heap, còn biến khai báo chỉ là một con trỏ (pointer/địa chỉ tham chiếu) được lưu trên Stack để trỏ tới vùng nhớ Heap đó.
•	Cơ chế lưu trữ và gán dữ liệu:
o	Value Types: Biến chứa trực tiếp giá trị thực. Khi thực hiện phép gán (b = a) hoặc truyền tham số vào hàm, hệ thống thực hiện sao chép toàn bộ giá trị (Copy-by-value). Biến mới là một bản sao độc lập, chỉnh sửa biến này không làm thay đổi biến kia.
o	Reference Types: Biến chỉ lưu địa chỉ trỏ tới đối tượng trên Heap. Khi gán (b = a), hệ thống chỉ sao chép địa chỉ tham chiếu. Cả hai biến cùng trỏ chung vào một vùng nhớ trên Heap; nếu thay đổi dữ liệu qua biến này, giá trị của biến kia cũng đổi theo.
•	Cơ chế giải phóng bộ nhớ:
o	Value Types: Tự động giải phóng ngay lập tức khi ra khỏi phạm vi hoạt động (scope) theo cơ chế LIFO của Stack, tốc độ giải phóng cực nhanh và không cần can thiệp của bộ thu gom rác.
o	Reference Types: Bộ nhớ trên Heap được quản lý và thu hồi tự động bởi Garbage Collector (GC) khi không còn bất kỳ biến tham chiếu nào trỏ tới đối tượng đó.
•	Ví dụ:
o	Value Types: int, float, double, bool, char, struct, enum.
o	Reference Types: class, string, interface, delegate, record, mảng (array).
Câu 2 Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.
Sự khác nhau giữa init và set thông thường:
•	Khả năng thay đổi dữ liệu (Mutability):
o	set: Cho phép gán hoặc sửa đổi giá trị của thuộc tính bất cứ lúc nào trong suốt vòng đời của đối tượng.
o	init: Chỉ cho phép gán giá trị một lần duy nhất tại thời điểm khởi tạo đối tượng (qua Constructor hoặc cú pháp Object Initializer { ... }). Sau khi đối tượng được tạo xong, thuộc tính trở thành bất biến (Read-only), không thể chỉnh sửa.
•	Cú pháp khởi tạo:
o	Thuộc tính init cho phép sử dụng Object Initializer linh hoạt mà không bắt buộc phải viết Constructor cồng kềnh với hàng loạt tham số (khắc phục điểm yếu của thuộc tính chỉ có get thông thường).
Trường hợp sử dụng thực tế:
•	Tạo đối tượng bất biến (Immutable Objects / DTO): Thường dùng cho các Data Transfer Object (DTO), Request/Response API hoặc Event Messages — nơi dữ liệu sau khi nhận về chỉ dùng để đọc, cần tránh việc vô tình sửa đổi làm sai lệch trạng thái logic.
•	Các định danh duy nhất (Identifier / Id): Các trường như UserId, OrderId, CreatedDate chỉ được xác định lúc tạo và phải giữ cố định suốt vòng đời dữ liệu.
•	Đảm bảo an toàn đa luồng (Thread-safety): Vì đối tượng không thể thay đổi dữ liệu sau khi tạo, nhiều luồng có thể cùng đọc dữ liệu mà không sợ xung đột hay cần dùng cơ chế khóa (lock).
Câu 3: Phân biệt virtual ở lớp cha và override ở lớp con (Tính Đa hình)
Trong C#, virtual và override phối hợp với nhau để hiện thực hóa cơ chế đa hình động (late binding / runtime polymorphism):
•	Từ khóa virtual (ở lớp cha):
o	Dùng để đánh dấu một phương thức là cho phép các lớp con ghi đè lại hành vi.
o	Cung cấp một cài đặt mặc định (default implementation). Lớp con không bắt buộc phải viết lại; nếu không viết lại, lớp con sẽ tự động dùng logic mặc định này của lớp cha.
•	Từ khóa override (ở lớp con):
o	Dùng để thực hiện việc ghi đè, định nghĩa lại logic xử lý mới thay thế cho phương thức virtual của lớp cha.
o	Chỉ có thể dùng trên phương thức đã được đánh dấu là virtual, abstract, hoặc một phương thức override trước đó.
•	Cơ chế hoạt động khi gọi qua con trỏ lớp cha:
o	Khi gọi phương thức thông qua biến kiểu lớp cha trỏ đến đối tượng lớp con (Parent p = new Child()), chương trình sẽ dựa vào bảng phương thức ảo (vtable) để thực thi phiên bản override của lớp con tại thời điểm chạy (runtime), thay vì phương thức virtual của lớp cha.
Câu 4: Tại sao thành phần static không thể truy xuất qua một thể hiện (Object Instance)?
Thành phần static không thể gọi qua thể hiện (ví dụ: obj.StaticMember) vì các lý do cốt lõi sau:
•	Cơ chế cấp phát bộ nhớ và quyền sở hữu:
o	Thành phần thể hiện (Instance member): Thuộc sở hữu riêng của từng đối tượng cụ thể, được cấp phát bộ nhớ riêng trên Heap mỗi khi tạo bằng toán tử new.
o	Thành phần tĩnh (static member): Thuộc sở hữu của chính Lớp (Type/Class), chỉ được cấp phát một vùng nhớ duy nhất (thường nằm ở vùng High Frequency Heap/Type metadata) khi lớp được nạp lần đầu, dùng chung cho mọi đối tượng.
•	Không tồn tại con trỏ this:
o	Phương thức/thành phần static không gắn với một đối tượng cụ thể nào, do đó nó không có ngữ cảnh this (không tham chiếu tới dữ liệu bên trong một instance cụ thể).
•	Quy chuẩn thiết kế của trình biên dịch C#:
o	Trình biên dịch C# chủ động cấm truy cập static qua instance để tránh gây hiểu lầm rằng thành phần đó là dữ liệu riêng của đối tượng đó.
o	Điều này đảm bảo tính tường minh trong code: mọi thao tác với thành phần static bắt buộc phải gọi trực tiếp qua tên lớp (ClassName.StaticMember).



