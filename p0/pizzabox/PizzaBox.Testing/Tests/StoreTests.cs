using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact] //attribute.must be as is
        public void Test_ChicagoStore_Fact()
        {
            // 1 arrange
            //subject under test
            var sut = new ChicagoStore(); //we want to test this
            var expected = "Chicago Store";

            // 2 act
            //part we actualy want to test
            var actual = sut.storeName;

            // 3 assert
            // what we expect actually happened
            Assert.Equal(expected, actual);
            //221
        }

        [Theory]
        //must be theoretically correct
        [InlineData("Chicago Store")] //expectation on the outside of the test

        public void Test_ChicagoStore_Theory(string expected)
        {
            // arrange
            var sut = new ChicagoStore();

            // act
            var actual = sut.storeName;

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_NYStore_Fact()
        {
            var sut = new NewYorkStore(); //we want to test this
            var expected = "NewYork Store";  //expect this

            var actual = sut.storeName;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("NewYork Store")]
        public void Test_NYStore_Theory(string expected)
        {
            var sut = new NewYorkStore();

            var actual = sut.storeName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_TexasStore_Fact()
        {
            var sut = new TexasStore(); //we want to test this
            var expected = "Texas Store";  //expect this

            var actual = sut.storeName;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Texas Store")]
        public void Test_TexasStore_Theory(string expected)
        {
            var sut = new TexasStore();

            var actual = sut.storeName;

            Assert.Equal(expected, actual);
        }
    }
}