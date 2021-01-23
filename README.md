# sweaj.serialization

A demonstration of fundamental process in computing, **serialization**. This was made for demonstrating the power
of serialization and its uses in everything computing. All software, networking, and everything else computing! This project was born from
making this [youtube video](https://www.youtube.com/watch?v=xjS06yX5mJw).

This repository simulates a .NET Core WPF client application, a ASP.NET Core MVC web-application, and an underlying ASP.NET Core WebAPI to demonstrate a simple application infrastructure common in many companies, reduced to the simplist parts. The project features two different projects, in two technologies, that can CRUD an external API to them using serialization. This is 

## Client (Sweaj.Serialization.Wpf)
In many software companies, there is a client application. The application usually is an executable on a specific platform 
or cross-platform, or a web application that is interfaced using a web browser, that the user uses. This is usually the product.

*In our case, the client a video uploading application for our end users. Client is a .NET Core Windows application powered by WPF.*

## Data (Sweaj.Serialization.Data)
All companies has data. This single project houses all of it. In the real world, there may be a models project that represents tables for a single database, and other projects to represent other databases. It's the classes that represent our data thats stored. We use EFCore as an object relational mapper tool to map instances of classes to rows of a particular table. 

Companies should *never* give direct access to this. Direct access would result in an client (a developer or nefarious party) gather unlimited data, without obstruction, abstraction, validation, or consent of the data owner. The way clients (end users) can access this data is through an API. This API is the Web API in this repository.

*In our case, the API is where our data-access-layer is, and other internal services. This is only immediately accessible from the Web App, not the client. The client requires communication with the Web API.*

## Web API (Sweaj.Serialization.WebApi)
Many companies have API's, application programmable interfaces that allows a client (a developer) in this case to
gather data or utilize data in a secure, controlled, and limited way that lives outside its control. It's an intermediate, or middleman to the
data access layer (DAL).

*In our case, the Web API is the middleman to communicate to the data access layer.*

## Web application (Sweaj.Serialization.WebApp)
This is one of the most prominent application technology choices for powering a software product.

*In our case, the web application is another client application hosted in this pretend companies intranet (internal to the company managers) where
they manage the videos that are uploaded from the Client (Sweaj.Serialization.Wpf).*
