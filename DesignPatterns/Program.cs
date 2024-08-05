using DesignPatterns.Repository.LocalRepository;
using DesignPatterns.Specification.PlayerSpecification;
using DesignPatterns.Template.PizzaExample;
using DesignPatterns.Template.TransactionProcessorExample;

TestSpecification();

Console.WriteLine('\n');

TestTemplateMethod();

Console.WriteLine('\n');

TestDepositTransactionTemplateMethod();

void TestSpecification()
{
    Console.WriteLine("== Testing Specification ==");

    var playerValidator = new PlayerFirstNameRule().And(new PlayerLastNameRule());

    var playerId = 1;

    var player = InMemoryPlayerRepository.GetPlayerById(playerId);

    ArgumentNullException.ThrowIfNull(player);

    var isPlayerValid = playerValidator.IsSatisfiedBy(player);

    var playerState = isPlayerValid ? "valid" : "invalid";

    Console.WriteLine($"The player {player.DisplayName} is {playerState}");
}

void TestTemplateMethod()
{
    Console.WriteLine("= Testing TemplateMethod ==");

    var pizzaBakingService = new PizzaBakingService();
    pizzaBakingService.Prepare();

    Console.WriteLine("======");

    var coldVeggiePizzaBakingService = new ColdVeggiePizzaBakingService();
    coldVeggiePizzaBakingService.Prepare();
}

void TestDepositTransactionTemplateMethod()
{
    var transactionProcessor = new DepositTransactionProcessor();

    transactionProcessor.ProcessTransaction();
}