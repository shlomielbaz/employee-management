# Employee Management

### The Project Structure
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

### Project Schema:
![image](https://user-images.githubusercontent.com/426076/219906557-24e0bf22-cd7f-4173-a450-ec6c65d36e11.png)


### Some snap-shots from the UI
Employee List
![image](https://user-images.githubusercontent.com/426076/219906295-b98555e5-3d2d-4aec-8d3d-5525108d71eb.png)

Employee View
![image](https://user-images.githubusercontent.com/426076/219906486-56bb7394-ec61-4114-8490-a117e4faebbb.png)
