using Microsoft.EntityFrameworkCore;
using TodoAPI;

var builder = WebApplication.CreateBuilder(args);
//Add DI - AddService -registering service
builder.Services.AddDbContext<TodoDb>(options =>
options.UseInMemoryDatabase("TodoList"));

var app = builder.Build();

//Configure pipeline - UseMethod
app.MapGet("/todoitems", async (TodoDb db) =>
await db.Todos.ToListAsync());

app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
await db.Todos.FindAsync(id));

app.MapPost("/todoitems", async (TodoItem todo, TodoDb db) =>
{
    db.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todoitems/{todo.Id}", todo);

});

app.MapPut("/todoitems/{id}", async (int id, TodoItem inputTodo, TodoDb db) =>
{
    var todo = await db.Todos.FindAsync(id);
    if (todo == null) return Results.NotFound();
    todo.IsComplete = inputTodo.IsComplete;
    todo.Name = inputTodo.Name;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/todoitems/{id}", async (int id, TodoDb db) =>
{
    var todo = await db.Todos.FindAsync(id);
    if (todo == null) return Results.NotFound();
    db.Todos.Remove(todo);
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.Run();
