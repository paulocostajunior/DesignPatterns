using DesignPatterns.Repository.LocalRepository;
using DesignPatterns.Specification.PlayerSpecification;
using DesignPatterns.Template.PizzaExample;

TestSpecification();

Console.WriteLine('\n');

TestTemplateMethod();

static void TestSpecification()
{
    Console.WriteLine("== Testing Specification ==");

    var playerValidator = new PlayerFirstNameRule().And(new PlayerLastNameRule());

    var playerId = 1;

    var player = InMemoryPlayerRepository.GetPlayerById(playerId);

    ArgumentNullException.ThrowIfNull(player);

    var isPlayerValid = playerValidator.IsStatisfiedBy(player);

    var playerState = isPlayerValid ? "valid" : "invalid";

    Console.WriteLine($"The player {player.DisplayName} is {playerState}");
}

static void TestTemplateMethod()
{
    Console.WriteLine("= Testing TemplateMethod ==");

    var pizzaBakingService = new PizzaBakingService();
    pizzaBakingService.Prepare();

    Console.WriteLine("======");

    var coldVeggiePizzaBakingService = new ColdVeggiePizzaBakingService();
    coldVeggiePizzaBakingService.Prepare();
}