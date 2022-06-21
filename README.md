# MTG-Application

This repository contains the code for a price-tracking and data visualization web app for Magic: The Gathering, using data gathered from my [MTG Script](https://github.com/bradenoestreich/MTG-Script) project.

## Objectives

AGILE stuff can be found [here](https://trello.com/b/FBabhalL/mtg-application)

- create a dynamic front-end app using SQL table of MTG card data.
- allow user to update a "collection" list of owned cards.
- store user interactions as valuable, persistent data using SQL.

## TODO
- [x] add basic user authentication (login/logout/register)
- [x] create a grid to view all the cards
- [x] create a collections page, and route it appropriately
- [ ] MVP: collections page that allows users to perform CRUD operations on a list of cards owned

## Running This Code

To acquire the data set, you will need to follow the instructions laid out in my [MTG Script](https://github.com/bradenoestreich/MTG-Script) project. 

Once the data has been extracted and formatted into a CSV, you will need establish a persistent database and connect it to this codebase. I used [these instructions](https://education.launchcode.org/csharp-web-development/chapters/orm-intro/background.html#setting-up-a-persistent-database-text) with slight modifications to set up my database.

Once the database has been created, you will need to import the data into the `cards` table.
