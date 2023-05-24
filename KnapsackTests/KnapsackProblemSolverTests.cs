using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Tests
{
    [TestClass()]
    public class KnapsackProblemSolverTests
    {
        [TestMethod()]
        public void FindBestItems_ShouldReturnCorrectItems()
        {
            // Arrange
            List<Item> items = new List<Item>()
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

            // Act
            List<Item> selectedItems = solver.FindBestItems(items, maxWeight);

            // Assert
            Assert.AreEqual(11, selectedItems.Count);
            Assert.IsTrue(selectedItems.Contains(items[0])); // map
            Assert.IsTrue(selectedItems.Contains(items[1])); // compass
            Assert.IsTrue(selectedItems.Contains(items[2])); // water
            Assert.IsTrue(selectedItems.Contains(items[3])); // sandwich
            Assert.IsTrue(selectedItems.Contains(items[4])); // glucose
            Assert.IsTrue(selectedItems.Contains(items[6])); // banana
            Assert.IsTrue(selectedItems.Contains(items[7])); // apple
            Assert.IsTrue(selectedItems.Contains(items[8])); // cheese
            Assert.IsTrue(selectedItems.Contains(items[10])); // suntan cream
            Assert.IsTrue(selectedItems.Contains(items[11])); // camera
            Assert.IsTrue(selectedItems.Contains(items[12])); // T-shirt
        }
    }
}
