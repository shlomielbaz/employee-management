# Employee Management
A _Employee Management_ is a simple CRUD operations application, 
it utilizes the [three-tier architecture](https://www.ibm.com/topics/three-tier-architecture) which emphasizes the separation between UI and business tiers, \
The server side use a .NET core built-in dependency injection mechanism, entityframework, repository pattern, unit-of-work pattern and more... \
The UI's use [Angular 15](https://angular.io/)

### The Project Structure
- **EM.Api** - responsible for incoming HTTP messages.
    - _Controllers_ - contains classes which handle the RESTFul API's.
- **EM.Data** - contains the DB context, repository, migration scripts and [SQLIte database](https://www.sqlite.org/index.html) file.
- **EM.Domain** - contains the "domain" app, which is a abstraction of the application.
  - _Entities_ - contains classes that reflect the DB schemas. 
  - _Enums_ - contains the application types. 
  - _General_ - contains classes for general use. 
  - _Helpers_ - contains helpers classes.
  - _Interfaces_ - contains interfaces that represent the application abstraction. 
  - _ViewModels_ - contains classes that represent data transfer object with UI views reflection.
- **EM.Services** - represent the mediator between the messaging tier and the business tier, and transform incoming messages from/to ViewModel's.
- **EM.Site** - contains the Angular (client-side) project

### A HTTP Message Flow Schema:
![image](https://user-images.githubusercontent.com/426076/219906557-24e0bf22-cd7f-4173-a450-ec6c65d36e11.png)

## Build the project's
- Server Side - build the project by Visual Studio or from EM.Api project run `dotnet build` CLI command.
- Client Side - from EM.Site run `npm install`

## Running the project's
- Using CLI's - from EM.Api project run `dotnet run`, from EM.Site run `npm start`

## Some snap-shots from the UI
#### **_Employee List_**:
![image](https://user-images.githubusercontent.com/426076/219934629-1f634e46-533e-4343-a3fd-3c169ef202e1.png)

#### **_Employee View_**:
![image](https://user-images.githubusercontent.com/426076/219935197-bcf76457-a93f-472d-b363-d5353c8abec0.png)
