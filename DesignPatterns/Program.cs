using DesignPatterns.Repository.LocalRepository;
using DesignPatterns.Specification.PlayerSpecification;

var playerValidator = new PlayerFirstNameRule().And(new PlayerLastNameRule());

var playerId = 1;

var player = InMemoryPlayerRepository.GetPlayerById(playerId);

ArgumentNullException.ThrowIfNull(player);

var isPlayerValid = playerValidator.IsStatisfiedBy(player);

var playerState = isPlayerValid ? "valid" : "invalid";

Console.WriteLine($"The player {player.DisplayName} is {playerState}");
