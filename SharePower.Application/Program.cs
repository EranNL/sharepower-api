using SharePower.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add domain services to container
builder.Services.AddInfrastructure(builderConfiguration: builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddAuthentication("Bearer").AddJwtBearer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use extensions
app.UseInfrastructure();
app.MapControllers();

app.UseRouting();

app.UseAuthorization();

app.Run();