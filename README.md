# Migrated Movies EF Core Demo Application

This is a demo that is linked to a soon to be published tutorial on migrating from PostgreSQL in an EF Core application to MongoDB. 
This is a common scenario for people looking to modernize their applications and enjoy the benefits of MongoDB's scalability, flexibility and performance.

## Running the application

You can run this application yourself by setting up a PostgreSQL database and loading the [sample data](https://mdb.link/rm-postgres-demo-data).

There is also a branch ```with-mongodb``` if you would like to run the MongoDB version.

Once you have a database available with the data loaded, you build and run from the .NET CLI in terminal:

```bash
dotnet run
```