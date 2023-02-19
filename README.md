# Employee Management
The _Employee Management_ is a simple CRUD operations application, 
it utilizes the [three-tier architecture](https://www.ibm.com/topics/three-tier-architecture) which emphasizes the separation between UI and business tiers, \
The server side use a .NET core built-in dependency injection mechanism, entityframework, repository pattern, unit-of-work pattern and more... \
The UI's use [Angular 15](https://angular.io/)

### The Project Structure
- **EM.Api** - responsible for incoming HTTP messages.
    - Controllers - contains classes which handle the RESTFul API's.
- **EM.Data** - contains the DB context, repository, migration scripts and [SQLIte database](https://www.sqlite.org/index.html) file.
- **EM.Domain** - contains the "domain" app, which is a abstraction of the application.
  - Entities - contains classes that reflect the DB schemas. 
  - Enums - contains the application types. 
  - General - contains classes for general use. 
  - Helpers - contains helpers classes.
  - Interfaces - contains interfaces that represent the application abstraction. 
  - ViewModels - contains classes that represent data transfer object with UI views reflection.
- **EM.Services** - represent the mediator between the messaging tier and the business tier, and transform incoming messages from/to ViewModel's.
- **EM.Site** - contains the Angular (client-side) project

### A HTTP Message Flow Schema:
![image](https://user-images.githubusercontent.com/426076/219906557-24e0bf22-cd7f-4173-a450-ec6c65d36e11.png)

### Some snap-shots from the UI
#### **_Employee List_**:
![image](https://user-images.githubusercontent.com/426076/219906295-b98555e5-3d2d-4aec-8d3d-5525108d71eb.png)

#### **_Employee View_**:
![image](https://user-images.githubusercontent.com/426076/219906486-56bb7394-ec61-4114-8490-a117e4faebbb.png)

## Build the project's
- Server Side - build the project by Visual Studio or from EM.Api project run `dotnet build` CLI command.
- Client Side - from EM.Site run `npm install`

## Running the project's
- Using CLI's - from EM.Api project run `dotnet run`, from EM.Site run `npm start`
- Using Visual Studio - set multiple startup project's:
![image](https://user-images.githubusercontent.com/426076/219932184-51cc35dd-2620-4630-af96-9de35971afab.png)

