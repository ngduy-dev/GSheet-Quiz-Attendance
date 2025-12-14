# 📝 GSheet Quiz Attendance

A C#-based automation system for tracking student attendance using quiz results collected via **Google Forms** and synchronized through **Google Sheets**.

The system automatically classifies attendance status (present/absent) based on predefined rules and sends email notifications when attendance thresholds are violated.

---

## 🚀 Key Features

### 🔹 Automated Data Synchronization
- Automatically pulls quiz submission data from **Google Sheets** linked to **Google Forms**
- Periodic synchronization to keep attendance status up to date

### 🔹 Rule-Based Attendance Logic
- **Present**: Submitted before the deadline **and** score ≥ passing threshold  
- **Absent**: Late submission **or** score below the required threshold

### 🔹 Reporting
- Generates absence reports grouped by class
- Exports structured attendance summaries for administrative review

### 🔹 Email Notifications
- Automatically sends warning emails when a student exceeds the allowed number of absences
- Uses **Gmail API** for secure email delivery

---

## 🛠 Tech Stack

- **Language:** C#
- **Framework:** .NET
- **APIs:** Google Sheets API, Google Forms (via Sheets), Gmail API
- **Others:** REST API integration, rule-based automation

---

## 🧩 System Workflow

1. Quiz responses are collected via **Google Forms**
2. Responses are synchronized to **Google Sheets**
3. The C# application:
   - Fetches data from Google Sheets
   - Applies attendance rules
   - Updates attendance status
   - Generates reports
   - Sends email notifications if needed

### Clone the repository
```bash
git clone https://github.com/ngduy-dev/GSheet-Quiz-Attendance.git
