# Selenium C# E-commerce Automation  

## Overview  
This project automates an end-to-end workflow of an e-commerce website using **Selenium WebDriver**, **C#**, and **NUnit**. The test script performs key actions such as searching for a product, adding it to the cart, proceeding to checkout, and validating order placement.  

---

## Features  
- Automates the following workflow:  
  1. Navigate to the e-commerce site.  
  2. Search for a product (e.g., "Laptop").  
  3. Select the first product from the search results.  
  4. Add the product to the shopping cart.  
  5. Proceed to checkout.  
  6. Validate successful order placement.  
- Uses **Page Object Model (POM)** for maintainable and modular test design.  
- Supports configuration via `appsettings.json`.  
- NUnit-based test execution with detailed assertions.  

---

## Technologies Used  
- **Programming Language**: C#  
- **Framework**: Selenium WebDriver  
- **Testing Framework**: NUnit  
- **Browser**: Google Chrome (Default)  
- **Additional Tools**: ExtentReports (optional for reporting)  

---

## Project Structure  

```plaintext  
selenium-csharp-ecommerce/  
├── src/  
│   ├── main/  
│   │   └── Automation/  
│   │       ├── Drivers/  
│   │       │   └── WebDriverSetup.cs  
│   │       ├── Pages/  
│   │       │   ├── HomePage.cs  
│   │       │   ├── SearchResultsPage.cs  
│   │       │   ├── ProductPage.cs  
│   │       │   ├── CartPage.cs  
│   │       │   └── CheckoutPage.cs  
│   │       ├── Tests/  
│   │       │   └── ECommerceTests.cs  
│   │       └── Utils/  
│   │           ├── ConfigReader.cs  
│   │           └── ReportManager.cs  
├── .gitignore  
├── README.md  
├── selenium-csharp-ecommerce.sln  
├── selenium-csharp-ecommerce.csproj  
└── appsettings.json  
```  

---

## Prerequisites  
- Install **Visual Studio** (2022 or later recommended).  
- Install **.NET 6.0 SDK** or higher.  
- Install **Google Chrome** (latest version).  
- Install the following NuGet packages:  
  - `Selenium.WebDriver`  
  - `Selenium.WebDriver.ChromeDriver`  
  - `NUnit`  
  - `NUnit3TestAdapter`  
  - (Optional) `ExtentReports`  

---

## Getting Started  

### 1. Clone the Repository  
```bash  
git clone https://github.com/your-username/selenium-csharp-ecommerce.git  
cd selenium-csharp-ecommerce  
```  

### 2. Open the Project in Visual Studio  
1. Open the `selenium-csharp-ecommerce.sln` solution file.  
2. Restore NuGet packages using Visual Studio or by running:  
   ```bash  
   dotnet restore  
   ```  

### 3. Update Configuration  
- Open `appsettings.json` and update the following values if necessary:  
  ```json  
  {  
      "BaseUrl": "https://example-ecommerce.com",  
      "Product": "Laptop"  
  }  
  ```  

### 4. Run the Tests  
- Open the **Test Explorer** in Visual Studio.  
- Build the project to detect the test cases.  
- Execute the `CompletePurchaseWorkflowTest` test.  

Alternatively, use the CLI:  
```bash  
dotnet test  
```  

---

## Key Classes and Files  

### 1. **Drivers/WebDriverSetup.cs**  
Handles browser initialization and configuration.  

### 2. **Pages/**  
Implements the Page Object Model (POM) for modular test design. Each class corresponds to a specific page of the e-commerce site.  

### 3. **Tests/ECommerceTests.cs**  
Contains test cases for the e-commerce workflow.  

### 4. **Utils/ConfigReader.cs**  
(Optional) A utility to read configuration values from `appsettings.json`.  

---

## Sample Test Flow  
1. Navigate to the home page.  
2. Search for "Laptop".  
3. Select the first product from the search results.  
4. Add the product to the cart.  
5. Proceed to checkout.  
6. Validate order success message on the checkout page.  

---

## Enhancements  
- Add support for multiple browsers (e.g., Firefox, Edge).  
- Parallel test execution using NUnit.  
- Dockerize the project for scalable execution.  
- Integrate with CI/CD tools like **GitHub Actions**, **Jenkins**, or **Azure Pipelines**.  

---

## Reporting  
(Optional) Generate detailed HTML test execution reports using **ExtentReports**.  

---

## Contributing  
Feel free to fork this repository and submit pull requests for improvements or additional features. 
