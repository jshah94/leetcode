using Algorithms;
using System;
using Xunit;


namespace TestProject1
{
    public class AlgoTests
    {
        [Fact]
        public static void SortedSquares()
        {
            //arrange
            int[] array = new int[] { -6, -3, 0, 2, 4, 7 };
            int[] respones = new int[] { 0, 4, 9, 16, 36, 49 };
            
            //act
            var res = ArraySortProblems.SortedSquares(array);

            //assert
            Assert.Equal(respones, res);
        }

        [Fact]
        public static void ShiftedBinarySearch()
        {
            //arrange
            int[] array = new int[] { 8, 9, 0, 2, 4, 7 };
            
            //act
            var response = ArraySearchProblems.ShiftedBinarySearch(array, 0);
            var response2 = ArraySearchProblems.ShiftedBinarySearch(array, 8);

            //assert
            Assert.Equal(2, response);
            Assert.Equal(0, response2);
        }

        [Fact]
        public static void LongestPeak()
        {
            //arrange
            int[] array = new int[] { 1,2,3,4,3,2,1};
            int[] array2 = new int[] { 1, 2, 5, 4, 3, 2, 1 };
            int[] array3 = new int[] { 5, 3, 2, 6, 5, 4, 7 };

            //act
            int peak = ArrayProblems.LongestPeak(array);
            int peak2 = ArrayProblems.LongestPeak(array2);
            int peak3 = ArrayProblems.LongestPeak(array3);
            //assert
            Assert.Equal(6, peak);
            Assert.Equal(6, peak2);
            Assert.Equal(3, peak3);
        }
    }
}
