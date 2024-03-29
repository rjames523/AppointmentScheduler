# AppointmentScheduler
## Performance assessment for C969 at WGU ##


### SCENARIO ###
You are working for a software company that has been contracted to develop a scheduling desktop user interface application. The contract is with a global consulting organization that conducts business in multiple languages and has main offices in Phoenix, Arizona; New York, New York; and London, England. The consulting organization has provided a MySQL database that your application must pull data from. The database is used for other systems and therefore its structure cannot be modified.

The organization outlined specific business requirements that must be included as part of the application. From these requirements, a system analyst at your company created solution statements for you to implement in developing the application. These statements are listed in the requirements section.


### REQUIREMENTS ###

You are not allowed to use frameworks or external libraries. The database does not contain data, so it needs to be populated. You must use “test” as the user name and password to login.

 
1.   Create a log-in form that can determine the user’s location and translate log-in and error control messages (e.g., “The username and password did not match.”) into the user’s language and in one additional language.


 
2.   Provide the ability to add, update, and delete customer records in the database, including name, address, and phone number. 


 
3.   Provide the ability to add, update, and delete appointments, capturing the type of appointment and a link to the specific customer record in the database.


 
4.   Provide the ability to view the calendar by month and by week. 


 
5.   Provide the ability to automatically adjust appointment times based on user time zones and daylight-saving time.


 
6.   Write exception controls to prevent each of the following. You may use the same mechanism of exception control more than once, but you must incorporate at least two different mechanisms of exception control.

    scheduling an appointment outside business hours
    scheduling overlapping appointments
    entering nonexistent or invalid customer data
    entering an incorrect username and password

 

7.  Write two or more lambda expressions to make your program more efficient, justifying the use of each lambda expression with an in-line comment.


 
8.  Write code to provide reminders and alerts 15 minutes in advance of an appointment, based on the user’s log-in.



9.   Provide the ability to generate each of the following reports using the collection classes:

    number of appointment types by month
    the schedule for each consultant
    one additional report of your choice



10.   Provide the ability to track user activity by recording timestamps for user log-ins in a .txt file. Each new record should be appended to the log file if the file already exists.


 
11.   Demonstrate professional communication in the content and presentation of your submission.
