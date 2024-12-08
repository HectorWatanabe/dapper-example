using DapperExample.Repositories;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

var connectionString = configuration["ConnectionStrings:DefaultConnection"];

if (string.IsNullOrEmpty(connectionString)) throw new Exception("File not found");

var accountRepository = new AccountRepository(connectionString);

var accounts = await accountRepository.GetAllAsync();

foreach (var account in accounts) Console.WriteLine($"{account.Bank}: {account.Number}");