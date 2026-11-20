# E2E Tests with Selenium/.NET for the "open Source Design" project

# About

This is an ongoing E2E test automation project that aims to serve as a test suite to validate critical functionalities of the following opensource project: "opensourcedesign.net". It is being developed using Selenium Webdriver with .NET 10 while applying Page Object Model structure.

# Prerequisites

Stacks needed to execute the tests:

- .NET 10 — framework for building and running the tests.
- Selenium WebDriver 4.50 — automates browser actions and checks the target website.
- Google Chrome + ChromeDriver 155 — the browser and driver used to run the automation.
- MSTest — the test framework, with Microsoft.NET.Test.Sdk to discover and run tests.
- Page Object Model (POM) — the structure used to keep page interactions separate from test scenarios.
- Coverlet — collects test coverage.
- DotNetSeleniumExtras.WaitHelpers — used for Selenium wait helpers.
- HttpClient - used for http requests.

# Project Structure

The project is developed with a "Page Object Model"  orientation in order to keep locators and test actions apart from each other. This increases the efficiency for the maintenance of the automations, because knowing where everything is - along with good naming practices - it makes it easier to get to the root cause of errors 

For each page of the website, it is being created a class with their objects and methods. These will be called on their respective Test class.

Also, each page has a test class, were the scenarios were designed to meet the requirements of the functionalities for their respctive page.

Smoke tests: In order to optimize the test of the website, the "Smoke" category is being added to the most critical scenarios. This way, the user can choose to check only the critical functionalities instead of executing all tests.

*Note:* The criticallity attributed to the functionalities assumed to be most commonly used. But the flags can be changed accordingly to the user necessities.


## Current Projetc Tree

```text
OSDe2eTests/
├── src/
│   ├── pages/
│   │   └── homePage.cs
│   └── tests/
|       ├──helpers/
|       |   └──httpHelper.cs
│       ├── homePageTests.cs
│       └── testBase.cs
├── e2e-tests-project.csproj
├── e2e-tests-project.sln
├── README.md
└── .gitignore
```

# Prerequisites and execution

*At the moment there are no executions. But here's how you can take a look at the project:

1. Have an IDE to run and execute the tests
2. Have the .NET10 installed (use dotnet --version at the terminal to check)
3. Clone the repository: git clone https://github.com/SandroAlvez/OpenSourceDesign-e2eTests.git
4. Restore the packages: dotnet restore e2e-tests-project.csproj
5. Compile the packages: dotnet build e2e-tests-project.csproj


# Project Status

## Done

- Technologies defined
- WebDriver lifecycle configured (*Note: the end of the lifecycle is commented at the moment for testing purposes)


## Ongoing

- Building the httpHelper.cs, which will execute link validations through http requests
- Finish the "Home Page" locator/methods class
- Finish "Home Page" tests

## Next steps

- Finish httpHelper.cs
- Build the "Events" page locator/methods class
- Build "Events" tests