# Bus Ticket Booking & Billing System

## Overview

This project is a C# Console Application developed as part of the **ServerCamp OOP Assignment**. The system allows users to manage bus ticket reservations, schedules, invoices, and payments while demonstrating Object-Oriented Programming (OOP) concepts and SOLID design principles.

---

## Features

### User Management

* Create User
* Display All Users

### Bus Management

* Create Bus
* Display All Buses

### Schedule Management

* Create Schedule
* Display All Schedules
* Display Schedule Details

### Ticket Booking

* Browse Available Schedules
* Select Preferred Seat
* Prevent Duplicate Seat Booking
* Generate Ticket

### Invoice & Payment

* Automatically Generate Invoice
* View User Invoices
* Process Invoice Payment

### Ticket Management

* Display User Tickets

---

## OOP Concepts Used

* Encapsulation
* Inheritance
* Abstraction
* Polymorphism

---

## SOLID Principles Applied

* Single Responsibility Principle (SRP)
* Open/Closed Principle (OCP)
* Dependency Injection through Service Classes

---

## Technologies Used

* C#
* .NET Console Application
* Object-Oriented Programming (OOP)
* Visual Studio Code

---

## Project Structure

```text
BusTicketBookingSystem
│
├── Models
│   ├── User.cs
│   ├── Bus.cs
│   ├── BusinessBus.cs
│   ├── EconomyBus.cs
│   ├── Schedule.cs
│   ├── Ticket.cs
│   └── Invoice.cs
│
├── Services
│   ├── UserService.cs
│   ├── BusService.cs
│   ├── ScheduleService.cs
│   ├── BookingService.cs
│   └── PaymentService.cs
│
├── Program.cs
└── BusTicketBookingSystem.csproj
```

---

## How to Run

### Clone Repository

```bash
git clone https://github.com/YOUR_USERNAME/BusTicketBookingSystem.git
```

### Navigate to Project Folder

```bash
cd BusTicketBookingSystem
```

### Run Application

```bash
dotnet run
```

---

## Available Operations

1. Create User
2. Display All Users
3. Create Bus
4. Display All Buses
5. Create Schedule
6. Display All Schedules
7. Display Schedule Details
8. Book Ticket
9. Display User Invoices
10. Process Invoice Payment
11. Display User Tickets
12. Exit

---

## Assignment Information

**Course:** ServerCamp OOP Assignment 01

**Project:** Bus Ticket Booking & Billing System

**Language:** C#

**Application Type:** Console Application

---

## Author

**Md.Mahathir Imam**
