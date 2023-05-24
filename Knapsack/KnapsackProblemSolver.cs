using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    public class KnapsackProblemSolver
    {
        public List<Item> FindBestItems(List<Item> items, int maxWeight)
        {
            int itemCount = items.Count;
            int[,] dpTable = new int[itemCount + 1, maxWeight + 1];

            for (int i = 1; i <= itemCount; i++)
            {
                Item currentItem = items[i - 1];
                for (int j = 1; j <= maxWeight; j++)
                {
                    if (currentItem.Weight > j)
                    {
                        dpTable[i, j] = dpTable[i - 1, j];
                    }
                    else
                    {
                        dpTable[i, j] = Math.Max(
                            dpTable[i - 1, j],
                            currentItem.Value + dpTable[i - 1, j - currentItem.Weight]
                        );
                    }
                }
            }

            List<Item> selectedItems = new List<Item>();
            int remainingWeight = maxWeight;

            for (int i = itemCount; i > 0 && remainingWeight > 0; i--)
            {
                if (dpTable[i, remainingWeight] != dpTable[i - 1, remainingWeight])
                {
                    Item selectedItem = items[i - 1];
                    selectedItems.Add(selectedItem);
                    remainingWeight -= selectedItem.Weight;
                }
            }

            selectedItems.Reverse();
            return selectedItems;
        }
    }
}
