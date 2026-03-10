var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

var todoApiGroup = app.MapGroup("/api/todo").WithTags("Todo API");

// Lista em memória para armazenar os todos
var todos = new List<TodoItem>
{
    new TodoItem { Id = 1, Title = "Tarefa 1", IsCompleted = false },
    new TodoItem { Id = 2, Title = "Tarefa 2", IsCompleted = true }
};

// GET: Listar todos
todoApiGroup.MapGet("/", () => Results.Ok(todos));

// GET: Obter por ID
todoApiGroup.MapGet("/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);
    return todo is not null ? Results.Ok(todo) : Results.NotFound();
});

// POST: Criar novo
todoApiGroup.MapPost("/", (TodoItem newTodo) =>
{
    newTodo.Id = todos.Max(t => t.Id) + 1;
    todos.Add(newTodo);
    return Results.Created($"/api/todo/{newTodo.Id}", newTodo);
});

// PUT: Atualizar
todoApiGroup.MapPut("/{id}", (int id, TodoItem updatedTodo) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);
    if (todo is null) return Results.NotFound();

    todo.Title = updatedTodo.Title;
    todo.IsCompleted = updatedTodo.IsCompleted;
    return Results.Ok(todo);
});

// DELETE: Remover
todoApiGroup.MapDelete("/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);
    if (todo is null) return Results.NotFound();

    todos.Remove(todo);
    return Results.NoContent();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

record TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
