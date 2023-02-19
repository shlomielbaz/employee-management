# Employee Management

The Project Structure
- **EM.Api** - responsible for incoming HTTP messages.
    - Controllers - contains classes that handle the RESTFul API's.
- **EM.Data** - contains the DB context and repository.
- **EM.Domain** - contains the "domain" app, which is the abstraction of the app.
  - Entities - contains classes that reflect the DB schemas. 
  - Enums - contains the application types. 
  - General - contains classes for general use. 
  - Helpers - contains helpers classes.
  - Interfaces - contains interfaces that represent the application abstraction. 
  - ViewModels - contains classes that represent data transfer object and views reflection.
- **EM.Services** - represent the transformation tier where incoming messages represented by ViewModels transform to Entities and vice versa.
- **EM.Site** - contains the Angular (client-side) project
