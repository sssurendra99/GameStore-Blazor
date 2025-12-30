using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients; 

public class GamesClient
{
     private readonly List<GameSummary> games = [
        new(){
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new(){
            Id = 2,
            Name = "Final Fantasy XIV",
            Genre = "RolePlaying",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new(){
            Id = 3,
            Name = "FIFA 23",
            Genre = "Sports",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2022, 9, 30)
        },
        new(){
            Id = 4,
            Name = "The Legend of Zelda: Tears of the Kingdom",
            Genre = "Adventure",
            Price = 69.99M,
            ReleaseDate = new DateOnly(2023, 5, 12)
        },
        new(){
            Id = 5,
            Name = "Elden Ring",
            Genre = "RolePlaying",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2022, 2, 25)
        },
        new(){
            Id = 6,
            Name = "Minecraft",
            Genre = "Sandbox",
            Price = 29.99M,
            ReleaseDate = new DateOnly(2011, 11, 18)
        },
        new(){
            Id = 7,
            Name = "Call of Duty: Modern Warfare II",
            Genre = "Shooter",
            Price = 69.99M,
            ReleaseDate = new DateOnly(2022, 10, 28)
        },
        new(){
            Id = 8,
            Name = "Red Dead Redemption 2",
            Genre = "Adventure",
            Price = 39.99M,
            ReleaseDate = new DateOnly(2018, 10, 26)
        },
        new(){
            Id = 9,
            Name = "Mortal Kombat 1",
            Genre = "Fighting",
            Price = 69.99M,
            ReleaseDate = new DateOnly(2023, 9, 19)
        },
        new(){
            Id = 10,
            Name = "Gran Turismo 7",
            Genre = "Racing",
            Price = 49.99M,
            ReleaseDate = new DateOnly(2022, 3, 4)
        },
        new(){
            Id = 11,
            Name = "Cyberpunk 2077",
            Genre = "RolePlaying",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2020, 12, 10)
        },
        new(){
            Id = 12,
            Name = "God of War Ragnarök",
            Genre = "Action",
            Price = 69.99M,
            ReleaseDate = new DateOnly(2022, 11, 9)
        }
    ];

    public List<GameSummary> GetGameSummaries()
    {
        return games;
    } 
}