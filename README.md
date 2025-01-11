**README**
**Calculator API with Unit Testing**
**This repository showcases a simple calculator API built using ASP.NET Core, alongside unit testing using Xunit. The code demonstrates fundamental concepts of API design, routing, and testing in C#.**

**Features**
Calculator Logic: A class that implements a Sum method to calculate the sum of two integers.
Unit Testing: Uses Xunit to verify the correctness of the calculator logic.
RESTful API: Provides a GET endpoint to perform addition operations via HTTP requests.
![Screenshot 2025-01-11 081817](https://github.com/user-attachments/assets/6b164a54-2cc6-43e8-a09c-8ec84c629a0a)

**1. Unit Testing (UnitTest1 Class)**
Located in the CalculatorTest namespace, this class uses Xunit to test the Sum method:

**How it works:**

Instantiates the Calculator class.
Verifies that adding 2 + 2 equals 4.
Throws an exception if the output is incorrect.

![Screenshot 2025-01-11 081836](https://github.com/user-attachments/assets/ab1d642b-0af7-43ed-9c84-3074bf4ff447)

**2. Calculator Logic (Calculator Class)**
Located in the Domain namespace, this class contains a simple method:




![Screenshot 2025-01-11 081904](https://github.com/user-attachments/assets/60ba561b-cb47-4174-9b76-c551ddd53e60)

**3. API Controller (CalculateController Class)
Located in the Web.Controllers namespace, this controller exposes the calculator functionality via a REST API:**

**Prerequisites**
.NET SDK
Xunit NuGet package for testing


