using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace SharePower.Infrastructure;

public static class InfrastructureExtension
{
    public static void UseInfrastructure(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseMigrationsEndPoint();
        // @TODO
    }
}