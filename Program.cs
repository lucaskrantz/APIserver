using APIserver;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/", GetHello);
app.MapGet("/", GetHello);
app.MapGet("/teachers/{number}", GetTeacher);
app.Run();

static Teacher GetTeacher(int number)
{
    List<Teacher> teachers = new() {
    new() {name = "Micke", hitPoints = 100},
    new() {name = "Martin", hitPoints = 1},
    new() {name = "Lena", hitPoints = 10},

    };
    return teachers[number];
}

static string GetHello()
{
    return "Hello"
;
}