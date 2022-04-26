# Sentence Generator

## Dependencies

1. Install SQL Server developer edition as a default instance 2016+
2. Node


## Database

We use a database project to store the state of the database. This project will create a SageOne database.
The location of the database project is contained in the source folder: Softline.Pastel.Database\Softline.Pastel.Database.sln
* 	In SSMS create an empty database called SentenceGeneratorDB
* 	Open solution explorer
* 	Right click on SentenceGenerator.Database
* 	Left click on Publish
* 	In the popup, using the Edit button, select you local sql server (.) and the select SentenceGeneratorDB
*	Set the variables as follows
    * DatabaseName SentenceGeneratorDB
* 	Click publish
* 	Once completed you will have a working and seeded SentenceGeneratorDB database. We create a demo company for you with working data.
