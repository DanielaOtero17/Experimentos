using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExperimentosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMergeSort()
        {
            var s = new EXPERIMENTOS.Sorts();

            int[] array = new int[10];

           array[0] = 99; array[1] = 77; array[2] = 1; array[3] = 23;
            array[4] = 17; array[5] = 12; array[6] = 56; array[7] = 4;
            array[8] = 28; array[9] = 33;

            s.DoMergesort(array);

            int[] aux = new int[10];
            aux[0] = 1;
            aux[1] = 4;
            aux[2] = 12;
            aux[3] = 17;
            aux[4] = 23;
            aux[5] = 28;
            aux[6] = 33;
            aux[7] = 56;
            aux[8] = 77;
            aux[9] = 99;

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(aux[i], array[i]);
            }
        }

        [TestMethod]
        public void TestQuickSort()
        {
            var s = new EXPERIMENTOS.Sorts();

            int[] array = new int[10];

            array[0] = 99; array[1] = 77; array[2] = 1; array[3] = 23;
            array[4] = 17; array[5] = 12; array[6] = 56; array[7] = 4;
            array[8] = 28; array[9] = 33;

            s.DoQuickSort(array);

            int[] aux = new int[10];
            aux[0] = 1;
            aux[1] = 4;
            aux[2] = 12;
            aux[3] = 17;
            aux[4] = 23;
            aux[5] = 28;
            aux[6] = 33;
            aux[7] = 56;
            aux[8] = 77;
            aux[9] = 99;

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(aux[i], array[i]);
            }
        }


        [TestMethod]
        public void TestTimeMerge()
        {
            var s = new EXPERIMENTOS.Sorts();

            int[] array = new int[10];

            array[0] = 99; array[1] = 77; array[2] = 1; array[3] = 23;
            array[4] = 17; array[5] = 12; array[6] = 56; array[7] = 4;
            array[8] = 28; array[9] = 33;

           String a = s.DoMergesort(array);

           Boolean comp = false;

            if (a != null)
                comp = true;

            Assert.IsTrue(comp);
        }

        [TestMethod]
        public void TestTimeQuick()
        {
            var s = new EXPERIMENTOS.Sorts();

            int[] array = new int[10];

            array[0] = 99; array[1] = 77; array[2] = 1; array[3] = 23;
            array[4] = 17; array[5] = 12; array[6] = 56; array[7] = 4;
            array[8] = 28; array[9] = 33;

            String a = s.DoQuickSort(array);

            Boolean comp = false;

            if (a != null)
                comp = true;

            Assert.IsTrue(comp);
        }


    }
}
