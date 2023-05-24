namespace Knapsack
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new()
        {
            new Item { Name = "map", Weight = 90, Value = 150 },
            new Item { Name = "compass", Weight = 130, Value = 35 },
            new Item { Name = "water", Weight = 1530, Value = 200 },
            new Item { Name = "sandwich", Weight = 500, Value = 160 },
            new Item { Name = "glucose", Weight = 150, Value = 60 },
            new Item { Name = "tin", Weight = 680, Value = 45 },
            new Item { Name = "banana", Weight = 270, Value = 60 },
            new Item { Name = "apple", Weight = 390, Value = 40 },
            new Item { Name = "cheese", Weight = 230, Value = 30 },
            new Item { Name = "beer", Weight = 520, Value = 10 },
            new Item { Name = "suntan cream", Weight = 110, Value = 70 },
            new Item { Name = "camera", Weight = 320, Value = 30 },
            new Item { Name = "T-shirt", Weight = 240, Value = 15 },
            new Item { Name = "trousers", Weight = 480, Value = 10 }
        };

            int maxWeight = 4000; // 4 kg

            KnapsackProblemSolver solver = new();
            List<Item> selectedItems = solver.FindBestItems(items, maxWeight);

            Console.WriteLine("Items to carry in the knapsack:");
            foreach (Item item in selectedItems)
            {
                Console.WriteLine($"{item.Name} (Weight: {item.Weight}g, Value: {item.Value})");
            }
        }
    }
}

