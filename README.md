# 📝 GSheet Quiz Attendance

Hệ thống tự động hóa quy trình điểm danh sinh viên dựa trên kết quả làm bài Quiz (Google Forms). Dữ liệu được đồng bộ qua Google Sheets API để xử lý trạng thái vắng/có mặt và gửi cảnh báo email tự động.

## 🚀 Tính năng chính

1.  **Đồng bộ dữ liệu:** Tự động pull kết quả từ Google Sheets (liên kết với Google Forms).
2.  **Logic điểm danh tự động:**
    * ✅ **Có mặt:** Nộp đúng hạn (Deadline) **VÀ** Điểm số >= Ngưỡng đạt.
    * ❌ **Vắng:** Nộp muộn **HOẶC** Điểm thấp hơn quy định.
3.  **Báo cáo:** Xuất file danh sách sinh viên vắng theo từng lớp.
4.  **Cảnh báo:** Tự động gửi email nhắc nhở nếu sinh viên vắng quá số buổi cho phép.

## 🛠 Công nghệ sử dụng

* **Language:** Python 3.8+
* **Google APIs:** Sheets API v4, Gmail API.
* **Libraries:** `gspread` (hoặc `google-api-python-client`), `pandas`, `python-dotenv`.

## Clone repo
```bash
git clone https://github.com/ngduy-dev/GSheet-Quiz-Attendance.git
'''
