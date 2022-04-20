# Modular Automation Quick Start  
## About  
MAQS stands for Modular Automation Quick Start.

It …
 - is a modular test automation framework
 - can be used as the base for your automation project or individual pieces can be used to enhance existing frameworks
 - is maintained/extended by automation engineers that use MAQS on a day to day bases

The main idea behind MAQS is to **avoid reinventing the wheel**. Most automation projects require the same basic set of features, and these features take a significant amount of time and effort to effectively implement. MAQS streamlines automation efforts by providing a framework with these base features built in. This allows engineers to spend their time testing, rather than building and maintaining a one-off testing framework.
  
![newproj.PNG](newproj.PNG)

![newitem.PNG](newitem.PNG)
  
![testrun.PNG](testrun.PNG)

## Why MAQS 
MAQS is a quick start for most any automation project. MAQS provides templates, configuration files, libraries, and helper methods to reduce the time required to initiate a test project with little setup. 
## How to use 
To create a new MAQS project, simply create a new solution using the MAQS templates and compile the project.  The templates included are compilable test solutions that includes a number of generic pre-written sample tests. 
Templates for Selenium, Appium, Playwright, Web Service, Database, Email, Generic and Composite (includes all the other types) tests are all included. 
## Features 
### Drivers
MAQS automatically setups up and cleans up Selenium, Appium, Web Service, Database, Mongo, and Email drives. These drivers provide you an interface with which to interact with the underlying system under test.  MAQS is also written in such a way that you can easily add your own driver type or use multiple driver and/or driver types within the same test.
### Logging 
MAQS provides logging in multiple file formats, as well as different logging levels depending on the importance and category of the log message. The logging levels can be used to suppress or log different kinds of information such as errors, warnings, successes, informational, generic messages, or logging to be altogether suspended. 
### Configurability/Extensibility 
MAQS was designed with configurability and extensibility in mind.  It supported JSON, XML, environment variable, and run time configuration settings.  This allows you to write your code once and run it against multiple environments with various configurations. It also allows you to override and/or provide your own implementation of most foundational components such as the logger and all the drivers. 
### Generic Waits 
MAQS provides generic wait methods that can be used without having to write code for explicit/implicit waits that Selenium provides. These methods wrap up common patterns that are used when a test interacts with a page, methods that wait for dynamic page elements to appear/disappear or become clickable. 
### Soft Asserts 
MAQS provides soft asserts that are used to store test assertions in a collection and will not fail a test until the test explicitly calls for it. This is useful for making multiple assertions, logging the results of those assertions, storing those results into a collection, and letting the tester decide how to handle any failed asserts without throwing an exception. 