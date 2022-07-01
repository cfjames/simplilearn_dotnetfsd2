using SchoolEfDAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SchoolContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolConnection"));
});
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapGet("/students", async(SchoolContext _context) =>
    await _context.Students.ToListAsync());

app.MapGet("/students/{id}", async (int id, SchoolContext _context) =>
    await _context.Students.FindAsync(id)
      is StudentModel student
        ? Results.Ok(student)
        : Results.NotFound());

app.MapPut("/students/{id}", async (int id, StudentModel studentModel,
    SchoolContext _context) =>
{
    if (id != studentModel.StudentID)
    {
        return Results.BadRequest();
    }

    _context.Entry(studentModel).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
       
            throw;
    }

    return Results.Ok(studentModel);
});

app.MapPost("/students", async (StudentModel studentModel, SchoolContext _context) =>
{
    if (_context.Students == null)
    {
        return Results.Problem("Entity set 'SchoolContext.Students'  is null.");
    }
    _context.Students.Add(studentModel);
    await _context.SaveChangesAsync();

    return Results.Ok(studentModel);
});

app.Run();

