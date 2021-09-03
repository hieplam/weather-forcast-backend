# weather-forcast-backend

## Framework used: Asp .Net core 5.0, Entity Framework

* Swagger document can be found in
`
YOUR_LOCAL_HOST/swagger/index.html
`

* Seed data and Database migration was handle automatically by EF core.
* Db connection strings and other config eg weather location, open weather api keys are stored in `appSettings.json`.
* Caching technique used: response cache, which configed from middleware in `Startup.cs`,
* The app also have global custom `JsonConverer` for `DateTime` to format datetime string.

## To apply seed data and db migration
1. Build all solution
2. Tools -> NuGet Package Manager -> Package Manager Console -> type `update-database`, seed data and db migration will run automaticaly


