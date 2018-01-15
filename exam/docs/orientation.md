# Backend Orientation Exam Competencies

## Interfaces and abstract classes

- usage of interfaces and abstract classes [(using an interface)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day02/workshop/excercise03/05-printable/05-printable/Todo.cs) [(using an abstract class)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day02/workshop/excercise02/03-instruments/03-instruments/BassGuitar.cs)
- understanding the difference between interfaces and abstract classes [(interface)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day02/workshop/excercise03/05-printable/05-printable/IPrintable.cs) [(abstract class)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day02/workshop/excercise02/03-instruments/03-instruments/StringedInstrument.cs)
- understand when to use interface and when to use super class (contracts vs. behaviours)

## Queries

- usage of language integrated quaries e.g. LINQ/StreamApi [(related content)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day03/workshop/excercise01/04/04/Program.cs)
- understanding the syntax [(related content)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day03/workshop/excercise01/08/08/Program.cs)
- able to write simple custom quaries [(related content)](https://github.com/greenfox-academy/bpo106/blob/master/week06/day03/workshop/excercise01/09/09/Program.cs)

## Build tool

- use build tools to build and run your applications e.g. gradle/.Net CLI
- dependency definition
- able to restore 3rd party library dependencies

## 3rd party libraries

- able to add and use libraries (add reference, using, stb.)
- find documentation and usage examples [(related content)](https://github.com/greenfox-academy/bpo106/tree/master/week09/day02/workshop/excercise01/Frontend)

## Backend Framework

- creating a Web Application with the given backend framework e.g. Spring/ASP.Net Core [(related content: todo app)](https://github.com/greenfox-academy/bpo106/tree/master/week08/day02/workshop/TodoApp/TodoApp/TodoApp)
- understanding the used components
- find documentation and usage examples
- understanding the framework and the application as web backend
- able to create examples for competencies of web backend
- using a templating system e.g. Thymeleaf/Razor Pages
- able to use the framework's special Dependency Injection system
- usage of the framework's IoC container
- able to alter basic configurations
- understanding the flow of HTTP

## Data persistance

- understanding and usage of basic SQL commands [(related content: todo app)](https://github.com/greenfox-academy/bpo106/tree/master/week08/day02/workshop/TodoApp/TodoApp/TodoApp)
  - `select`, `insert`, `update`, `delete`
- connecting database to backend application
  - database framework configuration
- understanding Object Relational Mapping
  - with using library: JPA/EF Core
- connection between:
  - tables and classes
  - records and objects
  - columns and fields/properties

## Web backend

- domain
- parts of the URL [(related content)](https://doepud.co.uk/images/blogs/complex_url.png)
- endpoint
- HTTP
  - Requests (GET url stb.)
  - Response (status codes)
  - methods (GET POST PUT stb.)
- headers
- body
- templates

### REST Web backend

- understand what is an API and can use it [(related content)](https://github.com/bpo106/pallida-orientation-exam-retake/blob/master/webshop/Webshop/Webshop/Controllers/ShoppingController.cs)
- use JSON objects (format, key-value pairs, stb.)
- understand the concept of serialization (JSON, stb.)
- able to use Postman

## Endpoint tests

- able to make difference between unit test and integration test [(integration tests)](https://github.com/greenfox-academy/bpo106/blob/master/week09/day02/workshop/excercise01/Frontend/FrontendTest/FrontendTests.cs)
- create endpoint test
  - with the help of a mock server [(related content)](https://github.com/greenfox-academy/bpo106/blob/master/week09/day03/workshop/excercise01/Groot/Groot.IntegrationTests/GuardianTests.cs)
