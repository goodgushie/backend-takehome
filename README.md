# Backend Take-Home Project
## Running the project
 - Clone the repo
 - Open the solution in Visual Studio
 - Run the project in debug mode (F5)
 - This should open the browser to the swagger UI
 - Click on the POST action for Quotes endpoint
 - Click the "Try it out" button on the right
 - Fill in the json parameters in the newly opened text field
 - Click "Execute" button below
 - Response will be displayed below
 - **NOTE:** You can also test this endpoint using tools like Postman
## Future Enhancements
### Factors
 - Expand the json input object to include additional parameters that would help the calculation like Hazard Factor
 - Move Hazard Factor to similar structure as other factors so it can be customized to tailor the quote
 - Expose available factors as GET endpoints so known options are readily available to external consumers
 - Add an infrastructure layer to a created or existing data source that contains factors so they can be modified easily
 - Cache factors (assuming factors do not change frequently)
### Logging
- Log any requests into a fire and forget data source as potential for analysis on requested quotes (What businesses are requesting most frequently, range of revenues, etc)
- Exception logging with debug information