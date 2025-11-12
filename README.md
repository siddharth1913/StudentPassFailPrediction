# StudentPassFailPrediction
# 🎓 Student Pass/Fail Prediction System (ML.NET)

> 🧠 Predict whether a student will **Pass or Fail** based on their **Study Hours** and **Attendance** — powered by **Machine Learning in .NET Core**.

![.NET](https://img.shields.io/badge/.NET%20Core-8.0-blueviolet)
![ML.NET](https://img.shields.io/badge/ML.NET-AI%20Model-success)
![CSharp](https://img.shields.io/badge/Language-C%23-blue)
![Status](https://img.shields.io/badge/Project-Working-brightgreen)

---

## 📘 Overview

This project uses **ML.NET** to build and train a **Binary Classification** model that predicts student performance.  
Given two inputs:
- 🕒 **Study Hours**
- 📈 **Attendance (%)**

…the model will predict whether the student will **Pass (TRUE)** or **Fail (FALSE)**.

---

## 🧩 Tech Stack

| Component | Description |
|------------|--------------|
| **Language** | C# (.NET Core 8.0 ) |
| **Framework** | ML.NET |
| **Algorithm** | SDCA Logistic Regression |
| **IDE** | Visual Studio / VS Code |
| **Data Format** | CSV (StudentHours, Attendance, PassOrNot) |

---


## 📊 Example Dataset

| StudentHours | Attendance | PassOrNot |
|---------------|-------------|-----------|
| 2 | 60 | FALSE |
| 8 | 95 | TRUE |
| 1 | 50 | FALSE |
| 6 | 85 | TRUE |
| 3 | 65 | FALSE |
| 7 | 92 | TRUE |
| 4 | 70 | TRUE |
| 1 | 30 | FALSE |
| 9 | 75 | TRUE |