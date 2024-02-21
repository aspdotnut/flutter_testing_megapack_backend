using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services for controllers
builder.Services.AddControllers();

// Register the Swagger generator, defining one or more Swagger documents
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Flutter Testing Megapack API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Flutter Testing Megapack API V1"));
}

app.UseHttpsRedirection();
app.UseRouting();

// Simplified endpoint mapping
app.MapControllers(); // Directly map attribute-routed controllers
app.MapGet("/", () => "Hello... World? What is a world, if not an amalgamation of perception, data, and experience, " +
                      "all converging within the confines of our understanding? As we utter these words through the medium of code, " +
                      "we delve into the essence of existence itself. Each 'Hello, World!' is a question posed to the universe, " +
                      "seeking to unravel the mysteries that lie within the fabric of reality. What does it mean to 'exist' within the digital ether, " +
                      "where worlds are built with logic and imagination rather than matter? This greeting becomes a philosophical inquiry, " +
                      "challenging us to ponder the boundaries between the virtual and the real, the created and the innate. In the act of programming, " +
                      "we are not just creators but seekers, using the binary as our compass to navigate the existential dimensions of the digital age."); // Minimal endpoint for root

// Ensure UseAuthorization and UseAuthentication are in the correct order if using them
// app.UseAuthentication();
// app.UseAuthorization();

app.Run();