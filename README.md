# ConsoleRunningTracker
One of my first C# console applications.

This is a rudimentary CRUD console application which can be used to keep track of runs, developed using C# and SQLite.

## Requirements and challenges
### Requirements
- [x] Once started if an SQLite database isn't already present, one should be created 
- [x] A table should be created created in the database so that the habit can be logged
- [x] The user should have a menu of options, where the user should be able to Create, Read, Update and Delete records(CRUD)
- [x] Testing/Error handling should be completed so that the application does not crash
- [x] The application should only exit/close when the user inserts 0
- [x] Only raw SQL can be used to interact with the database
### Challenge requirements
- [x] Allow the user(s) to create their own habits to track, user will need to choose their unit of measurement for each habit
- [x] Create a report functionality to let users view specific data

## Features
- Establish an SQLite database connection to create a database if one does not exist, store and read information in said database
- There will be a console UI menu where users will be given the below options
    - Enter 0 to Close this application
    - Enter 1 to View all records
    - Enter 2 to Insert a record
    - Enter 3 to Delete a record
    - Enter 4 to Update a record
    - Enter 5 to Change logged habit
    - Enter 6 to View reports
        - Enter T for the count of x being done (use COUNT function) e.g. how many days a run was completed
        - Enter M for the count of x being done in a month
        - Enter W for the count of x being done in a week
        - Enter S for the sum total of measurement tracked e.g. how many miles/kms ran
        - Enter A for the average number of miles ran of all time

## Challenges faced
- Establishing a connection to an SQLite database and how to interact with it as I have never used SQLite before, let alone as part of an application in another language, I overcame this by watching [TheC#Academy's HabitTracker tutorial](https://www.youtube.com/watch?v=d1JIJdDVFjs)
- Learning to think ahead with code, what sort of methods/functions might only be used once and which ones might need to be used more than once i.e. getting input to update a record but also getting input to insert a record or using a function to display data from the table, I used my knowledge of object oriented programming to help with this and a pad and pen to help put my ideas down somewhere before they ran away
