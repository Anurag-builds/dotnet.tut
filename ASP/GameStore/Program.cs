using GameStore.Dtos;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetGameEndPointName = "GetGame";

List<GameDto> games = [
    new(
        1,
        "Street Fighter",
        "Fighting",
        19.99M,
        new DateOnly(1992,7,15)),

    new(
        2,
        "Fighter3",
        "Dancing",
        20.29M,
        new DateOnly(1972,7,5)),
    new(
        3,
        "Street ",
        "real Life",
        44.44M,
        new DateOnly(2025,10,15))

];
// GET /games
app.MapGet("/games", () => games);

// GET /games/1
app.MapGet("/games/{id}", (int id) => games.Find(game => game.Id == id))
    .WithName(GetGameEndPointName);

app.MapPost("/games", (CreateGameDto newGame) =>
{
    GameDto game = new(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseOnly
    );
    games.Add(game);
    return Results.CreatedAtRoute(GetGameEndPointName, new { id = game.Id }, game);
});

app.MapPut("games/{id}", (int id, UpdateGameDto updatedGame) =>
{
    Console.WriteLine("hello");
    var index = games.FindIndex(game => game.Id == id);
    games[index] = new GameDto(
        id,
        updatedGame.Name,
        updatedGame.Genre,
        updatedGame.Price,
        updatedGame.ReleaseOnly
    );

    return Results.NoContent();
});

app.Run();
