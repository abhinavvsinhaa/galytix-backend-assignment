# Galytix

I have used C#, and Visual Studio for Mac (M1, arm64) to develop and build the assignment. The application is available on the port 9091 as per defined in the documentation, and the address is: https://localhost:9091/.

Swagger can be accessed on: https://localhost:9091/swagger/index.html

API Endpoint: https://localhost:9091/api/gwp/avg

Approach:

I've created a controller named ```CountryGWPController.cs``` inside the Controllers folder to catch the POST request on the route ```api/gwp/avg```, which calls a service named ```CSVService``` defined under the Services folder, to read the CSV file asynchronously, and return the desired output. 

## Screenshots

1. Successful compile and run :
<img width="1440" alt="Screenshot 2023-12-29 at 3 58 24 PM" src="https://github.com/abhinavvsinhaa/galytix-backend-assignment/assets/76272472/e521976a-5eae-4570-b2b9-1a72c8199d0e">
 
2. API Endpoint response
<img width="1387" alt="Screenshot 2023-12-29 at 3 58 49 PM" src="https://github.com/abhinavvsinhaa/galytix-backend-assignment/assets/76272472/4654a507-fe2c-4d9a-9f24-2531a88a345f">
