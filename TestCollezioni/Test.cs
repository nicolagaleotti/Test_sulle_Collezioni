using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetodiCollezioni;

namespace TestCollezioni
{
    [TestClass]
    public class Test
    {
        [DataTestMethod]
        [DataRow(new int[] {5, 1, 8, 3, 2}, new int[] {1, 2, 3, 5, 8})]
        [DataRow(new int[] {4, 2, 1, 7, 2}, new int[] {1, 2, 2, 4, 7})]
        public void TestOrdinamento(int[] array, int[] aspettato)
        {
            int[] narray = MetodiCollezioni.Metodi.Ordinamento(array);
            CollectionAssert.AreEquivalent(aspettato, narray);
        }
    }
}
