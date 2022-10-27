# Overview

This is a meetings schedule application to show off a basic understanding of Django. I use the MTV(Modle, View, Templet)
design to showcase some of my skills. The app shows a list of meetings, rooms, and allows the user to create new meetings.
I have used the Model to for the meeting and room data, Templates for the actual HTML documents and views to connect the HTML to the Model

[Django Project Video](https://youtu.be/xHxjiwdY3PE)

# Web Pages

* welcome.html is where the user begins, it shows a welcoming screen with a list of meetins.
It also has a link to the rooms and to create the meetings.
* detail.html has the meeting detail information
* rooms_list.html just list the rooms.
* new.html is the template for creating a new meeting.
* base.html is the main html template that also connects to my CSS file for the site as whole.

# Development Environment

I used PyCharm as my IDE. It provided all the neceessary troubleshooting tools, as well as a great way to see
the how all my files are organized. Django makes heavy use of files and having a tool where you can see your file structure
is very handy. PyCharm also comes with a Terminal that I can use Django commands to create a project, start an App, and 
run my local server to test with. 

I used the Django Framework for my development, this framework provided a lot of the features for this project. I used 
Modles for my meetings and rooms to store that information in a SQLite database file provided by Django. I used the form
factory to create forms as well as validation of forms. I used Template which are HTML files that hold special syntax to
communicate with variables in the Views I created.

# Useful Websites

* [Python Web Dev](https://realpython.com/learning-paths/become-python-web-developer/)
* [Django setup](https://realpython.com/lessons/setting-up-your-django-app/)
* [W3 Schools Django](https://www.w3schools.com/django/index.php)

# Future Work

* More CSS to make the site look better
* Ability to add rooms without being Admin
* Ability to not pick rooms that are already picked for a certain time
* Date and time pickers instead of text boxes
