Code is structured as follows:

There is one visual studio sultion BankAccount.sln

Within this solution are the following projects

1. Core bank account logic in BankAccount.csproj
1. Simple file system based "database" in TransactionStorage.csproj
1. Example command line app CommandLine.csproj
1. xUnit tests in unit test projects named i.e. BankAccountTests.csproj, TransactionStorageTest.csproj
1. Specflow based end2end test in End2EndTest.csproj

Open solution in visual studio and download nuget packages.

Set startup project either to CommandLine.csproj or execute the tests with a runner of your choice.