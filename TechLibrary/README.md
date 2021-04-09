# TechLibrary


### GitHub Repository 
[https://github.com/generic-widget-factory/phrasing] 

### Prequisites
Visual Studio 2019 (.net core framework 3.x) - [Community Edition Download](https://visualstudio.microsoft.com/downloads/) 


### Solution Setup Instructions 
1. Clone the github repository locally 
2. Open **TechLibrary.sln**

### Exercise context
1. Consumers submit data via a web form.  These "leads" are saved to the lead table. After leads are matched to agents, they are assigned to agents in the **AgentLead** table.
2. The Sqlite database (**leadDB.db**) schema can be found in *ExerciseDbSchema.pdf*
3. The Sqlite database can be accessed via the Data.DataContext.cs (Microsoft EntityFramework) or via direct SQL queries in Data.DataQuery (please refer to [https://sqlite.org/index.html])

### Coding Exercise Tasks 
Out of the box, the current solution uses a SQL Lite data source. Each API controller will return the entire data set for a given table (e.g Agency) via Microsoft EntityFramework DataContext. Please complete the tasks below. 

#### Task: Paginated leads per agent 
Create an API endpoint that will return 20 leads per request given an agent's ID (agent.id)
* Consider the  option for sorting the paginated results sorted by:
 * Last Name
 * City
 * State
 * Email
 * PostalCode
 * Address

#### Task: Search  
Create an API endpoint that will search across the join between the **Lead** table and the **AgentLead** table for leads:
* This endpoint will require either an AgentID parameter to filter on a single agent's leads, or the AgencyID parameter to filter for a single Agency
* Search parameters (at least one will be required): 
 * First Name
 * Last Name
 * City
 * State
 * Postal Code
 * Email
 * Address


#### Task: Agent Summary Widget Data
Create an API endpoint that will take an AgentID parameter and will return the following information from the **AgentLead** table (e.g. AgentID = 4 *"Derek Smalls"*)
* Count of leads for the  month of April 2021
* Total Agent spend for this period (if the agency table specifies "applySubsidy" = 1, then please subract agency.subsidyAmount from the agentLead.cost value). 
* Total Count and total spend for each InsuranceProduct type sold (e.g. Auto, Home, etc. - this requires a join to the **Lead** table). Factor in agency subsidy into these totals 
* Total count and monetary total of lead credit for this same period (agentLead.isCredited = 1, agentLead.cost minus any applicable subsidy)


#### Bonus Task: Credit a lead endpoint 
Create an API endpoint that will apply a credit for a given **AgentLead** record

#### Bonus Task: Monthly Spend Totals for 2021 
Create an API endpoint that will produce each month's summary, as per the task *Agent Summary Widget Data* (note, data for 2021 spans from January into April)


### Considerations
This development exercise is intended to be a ~ 2-4-hour exercise (+/-).  
Even though the current scope does not represent an enterprise application, please approach your application design with supporting such a production application in mind. 
100% completion is ideal, of course, but if you get to a stopping point before that and are unable to work up the entire exercise, please share your thoughts on how you approach this in a real-world scenario. 
Please talk about what online resources you can use for help and how you would approach going to your lead or peers to get support on finishing this code. 

Agile teams strive for maintainable, quality code that will be evaluated at build time in a Continuous Integration pipeline – please consider applying any/all applicable techniques and practices to this project towards these goals. 

If you find areas that you would choose to refactor, please do so and note your thought process behind the refactoring.
