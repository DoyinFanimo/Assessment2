# AudenTechnicalTest
 
## Explanation about Solution

I have completed the automation of https://www.auden.co.uk/credit/shorttermloan web application using Selenium WebDriver in C# and Specflow BDD framework using NUnit Microsoft.NET Core framework    

I started by downloading SpecFlow extension and adding the NuGet packages stated below  
Next, I created my file structures that was need to complete this task namely, Features, Hooks, PageObject and StepDefinitions files  
I created separate feature to automate the weekends i.e. for Saturday and Sunday in the Feature file   
The web UI elements were created in the PageObject while a class was instatiated in the StepDefinition so as to call the methods created in the PageObject  
The Hook file contains the code to initiate and close down the browser for each scenario.



### Tools Used

C# - This is the OOP language that is currently used in the company  

Selenuim WebDriver - is a useful and one of the most popular tool for cross brower testing. It also drives a browser native as a user would which makes it a good choice for the web application being tested 
The NuGet packages used includes selenium.support, selenium.webdriver, selenuim.webdriver.chromeDriver

Specflow - was used to write the feature in a BDD format which is enables collaboration between technical and non-technical parties in the business because of the conversational style  
The NuGet packages used includes: Specflow, SpecFlow.NUit, SpecFlow.Tools.MsBuild.Generation.

Page Object Model - This creates Object Repository for web UI elements. This is useful as it makes the codes reusable and easily maintained. It improve readability and reduces code duplication  

NUnit Assertion - This is used to validate the business requirement and ensures all business rules are followed

GIT/GIT Bash - for version control and uploading on GitHub
