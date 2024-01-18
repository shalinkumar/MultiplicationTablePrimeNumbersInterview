using MultiplicationTablePrimeNumbersInterview;
using Shouldly;

namespace MultiplicationTablePrimeNumbers.Test.Unit
{
    public class SolutionTest
    {
        [Fact]
        public void IsPrimeNumber_ShouldReturn_True()
        {
            var number = 2;
            //Act
            var response = Solution.IsPrimeNumber(number);
            //Assert
            Assert.True(response);
        }

        [Fact]
        public void IsPrimeNumber_ShouldReturn_False()
        {
            var number = 1;
            //Act
            var response = Solution.IsPrimeNumber(number);
            //Assert
            Assert.False(response);
        }

        [Fact]
        public void GetPrimeNumbers_ShouldReturn_PrimeNumbers()
        {
            var number = 6;

            //Act
            var response = Solution.GetPrimeNumbers(number);

            //Assert
            var result = response.ShouldBeOfType<List<int>>();

            _ = result[0].ShouldBeOfType<int>();
            result[0].ShouldBe(2);
            _ = result[1].ShouldBeOfType<int>();
            result[1].ShouldBe(3);
            _ = result[2].ShouldBeOfType<int>();
            result[2].ShouldBe(5);
            _ = result[3].ShouldBeOfType<int>();
            result[3].ShouldBe(7);
            _ = result[4].ShouldBeOfType<int>();
            result[4].ShouldBe(11);
            _ = result[5].ShouldBeOfType<int>();
            result[5].ShouldBe(13);
            _ = result[6].ShouldBeOfType<int>();
            result[6].ShouldBe(17);
        }

        [Fact]
        public void PrintGrid_ShouldReturn_MultiplicationTables()
        {
            var number = 2;
            //Act
            var response = Solution.PrintGrid(number);

            //Assert
            var result = response.ShouldBeOfType<List<int>>();

            _ = result[0].ShouldBeOfType<int>();
            result[0].ShouldBe(4);
            _ = result[1].ShouldBeOfType<int>();
            result[1].ShouldBe(6);
            _ = result[2].ShouldBeOfType<int>();
            result[2].ShouldBe(10);
            _ = result[3].ShouldBeOfType<int>();
            result[3].ShouldBe(6);
            _ = result[4].ShouldBeOfType<int>();
            result[4].ShouldBe(9);
            _ = result[5].ShouldBeOfType<int>();
            result[5].ShouldBe(15);
            _ = result[6].ShouldBeOfType<int>();
            result[6].ShouldBe(10);
            _ = result[7].ShouldBeOfType<int>();
            result[7].ShouldBe(15);
            _ = result[8].ShouldBeOfType<int>();
            result[8].ShouldBe(25);
        }

        [Fact]
        public void CheckValidNumber_ShouldReturn_True()
        {
            var number = 1;
            //Act
            var response = Solution.CheckValidNumber(number);
            //Assert
            Assert.True(response);
        }

        [Fact]
        public void CheckValidNumber_ShouldReturn_False()
        {
            var number = -1;
            //Act
            var response = Solution.CheckValidNumber(number);
            //Assert
            Assert.False(response);
        }

        [Fact]
        public void CheckValidNumberZeroShouldReturnFalse()
        {
            var number = 0;
            //Act
            var response = Solution.CheckValidNumber(number);
            //Assert
            Assert.False(response);
        }
    }
}