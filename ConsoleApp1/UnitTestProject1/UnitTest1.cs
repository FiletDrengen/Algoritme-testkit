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
            List<int> arr = new List<int> { 40, 1, 2, 5, 100, 2, 34, 4, 0, 2 };
            List<int> sor = new List<int> { 0, 1, 2, 2, 2, 4, 5, 34, 40, 100 };

            List<int> result = Program.Bubblesort(arr);

            Assert.AreEqual(sor, result, "Ikke sorteret");
        }

        public void QuickSort()
        {
            List<int> arr = new List<int> { 40, 1, 2, 5, 100, 2, 34, 4, 0, 2 };
            List<int> sor = new List<int> { 0, 1, 2, 2, 2, 4, 5, 34, 40, 100 };

            List<int> result = Program.Quick(arr);

            Assert.AreEqual(sor, result, "Ikke sorteret");
        }

        public void Insertionsort()
        {
            List<int> arr = new List<int> { 40, 1, 2, 5, 100, 2, 34, 4, 0, 2 };
            List<int> sor = new List<int> { 0, 1, 2, 2, 2, 4, 5, 34, 40, 100 };

            List<int> result = Program.Insertionsort(arr);

            Assert.AreEqual(sor, result, "Ikke sorteret");
        }
    }
}