# sweaj.serialization

A demonstration of fundamental process in computing **serialization**. This was made for demonstrating the power
of serialization and its uses in everything computing. All software, networking, and everything else computing!

This repository simulates a client (), web-application, and an underlying API to demonstrate a simple application infrastructure
common in many companies, but in a reductive way.

## Client (Sweaj.Serialization.Wpf)
In many software companies, there is a client application. The application usually is an executable on a specific platform 
or cross-platform, or a web application that is interfaced using a web browser, that the user uses. This is usually the product.

*In our case, the client a video uploading application for our end users. Client is a .NET Core Windows application powered by WPF.*

## Data (Sweaj.Serialization.Data)
Many companies have API's, application programmable interfaces that allows a client (a developer) in this case to
gather data or utilize data in another application that lives somewhere else. It's the classes that represent our data thats stored.

Companies *never* give direct access to this. The way clients (end users) can access this data is through an API. This API is the Web API in this repository.

*In our case, the API is where our data-access-layer is, and other internal services. This is only immediately accessible from the Web App, not the client. The client requires communication with the Web API.*

## Web API (Sweaj.Serialization.WebApi)
Many companies have API's, application programmable interfaces that allows a client (a developer) in this case to
gather data or utilize data in another application that lives somewhere else. It's an intermediate, or middleman. 

*In our case, the Web API is the middleman to communicate to the data access layer.*

## Web application (Sweaj.Serialization.WebApp)
This is one of the most prominent application hosting choices for a software product. It uses the most well-known webbrowser
web-applicaiton that can serve/process data.

*In our case, the web application is another client application hosted in this pretend companies intranet (internal to the company managers).*
