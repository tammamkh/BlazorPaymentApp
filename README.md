# Blazor Payment App

This is a simple Blazor (Server or WebAssembly) application demonstrating **Dependency Injection (DI)** with a mock **Payment Service**.

## 💡 Features

- Input for card number and payment amount
- Injected payment service (`IPaymentService`)
- Mock processing logic with success/fail response
- Designed for educational/demo purposes

## 🛠️ Technologies

- .NET 8 / 9
- Blazor (Server or WASM)
- C#
- Razor Components

## 🔧 How It Works

1. User enters a card number and amount
2. Clicks **"Pay Now"**
3. `IPaymentService` is used via Dependency Injection to simulate payment
4. Message appears: **Payment Successful!** or **Payment Failed.**

## 📁 Folder Structure
PaymentDependencyInjection/
├── Pages/
│ └── Payment.razor # UI page for payment
├── Services/
│ ├── IPaymentService.cs # Interface for DI
│ └── PaymentService.cs # Implementation
└── Program.cs # DI registration


## 🚀 Getting Started

1. Clone the repo:

```bash
git clone https://github.com/tammamkh/BlazorPaymentApp.git
cd BlazorPaymentApp

