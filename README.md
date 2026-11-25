# NT106.R11 - Nhóm 4: Chương Trình Quản Lý Khách Sạn

Ứng dụng Windows Forms quản lý khách sạn (.NET Framework 4.7.2) kết nối trực tiếp với **Cloud Database Supabase (PostgreSQL)**, hỗ trợ đồng bộ dữ liệu trực tuyến thời gian thực giữa các máy tính.

---

## 🚀 Hướng Dẫn Chạy Chương Trình

### Cách 1: Chạy trực tiếp file thực thi (.exe)
1. Truy cập thư mục: `bin\Debug\`
2. Click đúp vào file `ChuuongTrinhQuanLyKhachSan.exe` để mở chương trình.
3. Ứng dụng sẽ tự động kết nối đến Cloud Database của nhóm mà không cần cài đặt SQL Server trên máy.

### Cách 2: Mở và chạy từ Visual Studio
1. Mở file solution `ChuuongTrinhQuanLyKhachSan.slnx` (hoặc mở thư mục project trong Visual Studio).
2. Nhấn phím `F5` hoặc nút **Start** để khởi chạy.

---

## 🔑 Tài Khoản Đăng Nhập
Tại màn hình đăng nhập, bạn có thể sử dụng một trong các tài khoản sau:

| Loại tài khoản | Username | Password | Ghi chú |
| :--- | :--- | :--- | :--- |
| **Admin mặc định** | `Long` | `123` | Tài khoản cứng dự phòng |
| **Admin CSDL Cloud** | `admin` | `123` | Khởi tạo sẵn trên Supabase |
| **Nhân viên tạo mới** | *(Username tự tạo)* | *(Password tự tạo)* | Được cấp trong mục **Nhân Viên** |

---

## 📖 Hướng Dẫn Sử Dụng Các Chức Năng

Sau khi đăng nhập thành công, màn hình chính (**Dashboard**) sẽ hiển thị thanh điều hướng trên cùng với 5 chức năng chính:

### 1. Thêm Phòng (`Thêm Phòng`)
- **Mục đích:** Khởi tạo danh sách các phòng trong khách sạn.
- **Cách thao tác:**
  1. Nhập **Số Phòng** (ví dụ: `101`, `102`, `201`).
  2. Chọn **Loại Phòng** (`AC` - Máy lạnh hoặc `Non-AC` - Quạt).
  3. Chọn **Loại Giường** (`Single` - Đơn, `Double` - Đôi, `Triple` - Ba).
  4. Nhập **Giá Phòng** (Đơn vị VNĐ, chỉ nhập số nguyên dương, ví dụ: `500000`).
  5. Nhấn **Thêm Phòng**. Bảng danh sách bên dưới sẽ cập nhật ngay lập tức.

---

### 2. Đăng Ký Khách Hàng / Đặt Phòng (`Đăng Ký Khách Hàng`)
- **Mục đích:** Tiếp nhận khách hàng và gán phòng lưu trú.
- **Cách thao tác:**
  1. Nhập thông tin khách: Họ tên, Số điện thoại, Quốc tịch, Giới tính, Ngày sinh, CCCD/CMND, Địa chỉ, Ngày nhận phòng.
  2. Chọn thông tin phòng:
     - Chọn **Loại Giường** -> Chọn **Loại Phòng**.
     - ComboBox **Số Phòng** sẽ tự động lọc và chỉ hiển thị các phòng còn trống (`booked = 'NO'`).
     - Chọn số phòng mong muốn -> Ô **Giá Tiền** sẽ tự động hiển thị giá tương ứng.
  3. Nhấn **Nhận Phòng**.
  4. Sau khi đăng ký thành công, phòng đó sẽ tự động chuyển sang trạng thái đã đặt (`booked = 'YES'`) và không còn xuất hiện trong danh sách phòng trống.

---

### 3. Thanh Toán / Trả Phòng (`Thanh Toán`)
- **Mục đích:** Xử lý trả phòng và cập nhật trạng thái phòng sẵn sàng đón khách mới.
- **Cách thao tác:**
  1. Bảng dữ liệu sẽ tự động hiển thị danh sách tất cả các khách hàng **chưa trả phòng**.
  2. Bạn có thể tìm nhanh khách hàng bằng cách gõ tên vào ô **Tìm Kiếm**.
  3. **Click chuột vào dòng khách hàng** trên bảng -> Tên khách và số phòng sẽ tự động điền vào form thanh toán bên dưới.
  4. Chọn **Ngày Thanh Toán** -> Nhấn **Thanh Toán**.
  5. Khi xác nhận thanh toán thành công:
     - Khách hàng được chuyển trạng thái sang đã thanh toán (`chekout = 'YES'`).
     - Số phòng tương ứng sẽ tự động chuyển về trạng thái trống (`booked = 'NO'`).

---

### 4. Tra Cứu Dữ Liệu Khách Hàng (`Chi Tiết Khách Hàng`)
- **Mục đích:** Xem toàn bộ lịch sử khách hàng đã và đang lưu trú.
- **Cách thao tác:**
  - Sử dụng hộp chọn **Tìm Kiếm Theo**:
    - **Tất Cả Thông Tin Khách Hàng:** Hiển thị toàn bộ lịch sử từ trước đến nay.
    - **Khách Hàng Chưa Thanh Toán:** Chỉ hiển thị những khách đang còn ở trong khách sạn.
    - **Khách Hàng Đã Thanh Toán:** Danh sách các khách đã trả phòng.
  - Bảng hiển thị đầy đủ thông tin: Mã khách, Họ tên, SĐT, CCCD, Ngày đến, Số phòng, Loại phòng, Giá tiền.

---

### 5. Quản Lý Nhân Viên (`Nhân Viên`)
- **Tab 1 - Đăng Ký Nhân Viên:**
  - Nhập thông tin nhân viên: Họ tên, Số điện thoại, Giới tính, Email, Tên tài khoản, Mật khẩu.
  - Mã nhân viên (ID) được hệ thống tự động tăng theo số thứ tự.
  - Bấm **Đăng Ký** -> Tài khoản này có thể dùng để đăng nhập vào hệ thống ngay lập tức.
- **Tab 2 - Chi Tiết Nhân Viên:**
  - Hiển thị bảng danh sách toàn bộ nhân viên trong hệ thống.
- **Tab 3 - Xóa Nhân Viên:**
  - Nhập ID nhân viên cần xóa -> Nhấn **Xóa** và xác nhận.

---

## ☁️ Hướng Dẫn Xem Dữ Liệu Trực Tiếp Trên Cloud Supabase

Mọi thao tác bạn thực hiện trên ứng dụng đều được lưu trữ trực tuyến. Để xem dữ liệu trên trình duyệt:

1. Đăng nhập vào [Supabase Dashboard](https://supabase.com/dashboard/project/anvutdehyxkhfrhifhlf).
2. Ở thanh menu màu đen bên trái ngoài cùng, chọn biểu tượng **Table Editor** (biểu tượng thứ 2 từ trên xuống hình bảng lưới).
3. Chọn các bảng để xem dữ liệu thời gian thực:
   - `rooms`: Xem danh sách phòng và trạng thái `booked` (`YES` / `NO`).
   - `customer`: Xem dữ liệu khách hàng, ngày checkin, checkout.
   - `employee`: Xem danh sách nhân viên và tài khoản.
