# Overview

The purpose of this software was to show how to interact with a SQL Database in Python.
I wanted to use the CRUD process and create rows using an INSERT, Read by just quering all the data. I aslo
have a way to select a specific id in the table. Update is just using an update with a check to make
sure that the ID is actually in the table and finally a Delete function which does the same check as Update and then
deletes the specified row.

[Software Demo Video](http://youtu.be/HfA5pg2F1Tc?hd=1)

# Relational Database

My table is super simple. My wife likes to collect fossils so I thought I would make a
simple table to hold those items. It just has the ID, type(dino, plant, bug, other animal), Name, Price
, and size. I will expand it to have other detail on constraints down the road but for now I just had to 
keep it simple. I will also add other tables in the Collections Database I created that my wife, my self and my children
have.

# Development Environment
I used MySQL Workbench to create the database and to create the table.
I used PyCharm as my IDE for the python code to create my main project.

# Useful Websites

{Make a list of websites that you found helpful in this project}
* [CRUD Operations](https://examples.javacodegeeks.com/crud-operations-in-python-on-mysql/)
* [SQL Statements](https://www.w3schools.com/sql/sql_update.asp)


# Future Work

* Add more tables for other collections
* Add more constraints on the tables
* Add better handling of deleting and updating as well as better selects for reports
* Find a way to integrate this to a web application for a better User Interface.