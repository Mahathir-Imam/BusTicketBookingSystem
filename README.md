# Bus Ticket Booking & Billing System

## Overview

This project is a C# Console Application developed as part of the ServerCamp OOP Assignment. The system allows users to manage bus ticket reservations, schedules, invoices, and payments while demonstrating Object-Oriented Programming (OOP) concepts and SOLID principles.

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

## OOP Concepts Used

* Encapsulation
* Inheritance
* Abstraction
* Polymorphism

## SOLID Principles Applied

* Single Responsibility Principle (SRP)
* Open/Closed Principle (OCP)
* Dependency Injection through Service Classes

## Technologies Used

* C#
* .NET Console Application
* Object-Oriented Programming (OOP)

## Project Structure

BusTicketBookingSystem/
│
├── Models/
│   ├── User.cs
│   ├── Bus.cs
│   ├── BusinessBus.cs
│   ├── EconomyBus.cs
│   ├── Schedule.cs
│   ├── Ticket.cs
│   └── Invoice.cs
│
├── Services/
│   ├── UserService.cs
│   ├── BusService.cs
│   ├── ScheduleService.cs
│   ├── BookingService.cs
│   └── PaymentService.cs
│
└── Program.cs

## How to Run

1. Clone the repository
2. Open the project in Visual Studio Code
3. Run the following command:

```bash
dotnet run
```

## Assignment Information

Course: ServerCamp OOP Assignment 01

Project: Bus Ticket Booking & Billing System

Language: C#
