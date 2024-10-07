using Adapter_Pattern;
internal class Program
{
    private static void Main(string[] args)
    {
        ComputerGame computerGame = new ComputerGame(name:"Hamster Combat",pegiAgeRating:PegiAgeRating.P7,budgetInMillionsOfDollars:1,minimumGpuMemoryInMegabytes:10,diskSpaceNeededInGB:1,ramNeededInGb:1,coresNeeded:1,coreSpeedInGhz:2.4);
        ComputerGameAdapter adapter = new ComputerGameAdapter(computerGame);
        Console.WriteLine(adapter.getTitle());
        Console.WriteLine(adapter.getPegiAllowedAge());
        Console.WriteLine(adapter.getRequirements().ToString());
        if (adapter.isTripleAGame())
        {
            Console.WriteLine("TripleA Game");
        }
        else
        {
            Console.WriteLine("Not tripleA game");
        }
    }
}