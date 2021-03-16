using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    using SortTest3;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSort()
        {
            List<int> arr = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            List<int> sor = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> result = Program.Bubblesort(arr);

            CollectionAssert.AreEqual(result, sor, "Ikke sorteret");
        }

        [TestMethod]
        public void QuickSort()
        {
            List<int> arr = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            List<int> sor = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> result = Program.Quick(arr);

            CollectionAssert.AreEqual(result, sor, "Ikke sorteret");
        }

        [TestMethod]
        public void Insertionsort()
        {
            List<int> arr = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            List<int> sor = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> result = Program.Insertionsort(arr);

            CollectionAssert.AreEqual(result, sor, "Ikke sorteret");
        }
    }
}