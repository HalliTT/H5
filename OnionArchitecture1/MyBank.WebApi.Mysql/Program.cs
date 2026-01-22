using Microsoft.EntityFrameworkCore;
using MyBank.Application.Interfaces;
using MyBank.Application.Services;
using MyBank.Domain.Services.Interfaces;
using MyBank.Domain.Services.Services;
using MyBank.Infrastructure.Persistence;
using MyBank.Infrastructure.Repositories;

namespace MyBank.WebApi.Mysql
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            //builder.Services.AddOpenApi();

            var connectionString = builder.Configuration.GetConnectionString("MyBankMySql")
                ?? throw new InvalidOperationException("MySQL connection string not found.");

            builder.Services.AddDbContext<BankDbContext>(opt => opt.UseSqlServer(connectionString, x => x.MigrationsAssembly("MyBank.Infrastructure")));
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<IAccountAppService, AccountAppService>();
            builder.Services.AddScoped<TransferDomainService>();

            builder.Services.AddSwaggerGen(c => {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                c.CustomSchemaIds(type => type.FullName);
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
