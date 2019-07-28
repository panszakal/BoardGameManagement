using Bogus;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeService
{
    public class Generator
    {
        private Faker<Game> FakeGame => new Faker<Game>()
            .StrictMode(true)
            .RuleFor(g => g.ID, f => f.IndexFaker + 1)
            .RuleFor(g => g.GameName, f => f.Company.CompanyName())
            .RuleFor(g => g.MinimumNumberOfPlayers, f => f.Random.Int(1, 10))
            .RuleFor(g => g.MaximumNumberOfPlayers, (f, u) => f.Random.Int(u.MinimumNumberOfPlayers, 20))
            .RuleFor(g => g.RecommendedAge, f => f.Random.Int(3, 16))
            .FinishWith((f, u) => Console.WriteLine($"Game {u.GameName} was created."))
            ;

        private Faker<GameHistory> FakeGameHistory => new Faker<GameHistory>()
            .StrictMode(true)
            .RuleFor(g => g.ID, f => f.IndexFaker + 1)
            .RuleFor(g => g.GameID, f => f.Random.Int(1, 100))
            .RuleFor(g => g.GameDateTime, f => f.Date.Past(0))
            .RuleFor(g => g.Source, f => f.PickRandom<string>(new string[] { "webservice", "www application" }))
            ;

        public IList<Game> Games { get; private set; }
        public IList<GameHistory> GamesHistory { get; private set; }

        public Generator()
        {
            Games = FakeGame.Generate(100);
            GamesHistory = FakeGameHistory.Generate(100);
        }
    }
}
