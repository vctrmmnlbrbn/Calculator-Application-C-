# 🧮 CalculatorApplication (C# WinForms)

A simple Windows Forms calculator application built in **C#** using **delegates** and **events**.  
This project was developed as part of **Laboratory Exercise 2.1** for practicing generic delegates and custom event accessors.

---

## 🚀 Features
- Perform **basic arithmetic operations**:
  - Addition (`+`)
  - Subtraction (`-`)
  - Multiplication (`*`)
  - Division (`/`)
- Uses **delegate and event handling** to execute operations.
- Demonstrates **custom add/remove accessors** with console logging.
- Handles divide-by-zero exceptions gracefully.

---

## 🛠️ Technologies Used
- **C#**
- **.NET Framework (Windows Forms)**
- **Visual Studio IDE**

---

## 📂 Project Structure
CalculatorApplication/
│── CalculatorClass.cs # Contains delegate, event, and arithmetic methods
│── FrmCalculator.cs # Main Windows Form UI and event handling
│── Program.cs # Entry point for the application
│── README.md # Project documentation

---

## 📖 How It Works
1. The user enters two numbers in the text boxes.
2. The user selects an operator (`+`, `-`, `*`, `/`) from the combo box.
3. When **Equal (=)** is clicked:
   - The corresponding method (`GetSum`, `GetSubtraction`, `GetProduct`, or `GetQuotient`) is subscribed to the event.
   - The event is invoked, and the result is displayed in the label.

Console output will also show whether a delegate was **added** or **removed**.

---

## ▶️ Example Usage
- Input1: `10`  
- Operator: `+`  
- Input2: `5`  
- Output: `15`  

Console:

Added the Delegate
---

## 🧑‍💻 Installation & Running
1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/CalculatorApplication.git
