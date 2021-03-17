using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTest
    {
        [Fact] //attribute.must be as is
        public void Test_MeatPizza_Fact()
        {
            // 1 arrange
            //subject under test
            var sut = new MeatPizza(); //we want to test this
            var expected = "Meat Pizza";

            // 2 act
            //part we actualy want to test
            var actual = sut.Name;

            // 3 assert
            // what we expect actually happened
            Assert.Equal(expected, actual);
            //221
        }

        [Theory]
        //must be theoretically correct
        [InlineData("Meat Pizza")] //expectation on the outside of the test

        public void Test_MeatPizza_Theory(string expected)
        {
            // arrange
            var sut = new MeatPizza();

            // act
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact] //attribute.must be as is
        public void Test_PepPizza_Fact()
        {
            // 1 arrange
            //subject under test
            var sut = new PepPizza(); //we want to test this
            var expected = "Pepperoni Pizza";

            // 2 act
            //part we actualy want to test
            var actual = sut.Name;

            // 3 assert
            // what we expect actually happened
            Assert.Equal(expected, actual);
            //221
        }

        [Theory]
        //must be theoretically correct
        [InlineData("Pepperoni Pizza")] //expectation on the outside of the test

        public void Test_PepPizza_Theory(string expected)
        {
            // arrange
            var sut = new PepPizza();

            // act
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact] //attribute.must be as is
        public void Test_CheesePizza_Fact()
        {
            // 1 arrange
            //subject under test
            var sut = new CheesePizza(); //we want to test this
            var expected = "Cheese Pizza";

            // 2 act
            //part we actualy want to test
            var actual = sut.Name;

            // 3 assert
            // what we expect actually happened
            Assert.Equal(expected, actual);
            //221
        }

        [Theory]
        //must be theoretically correct
        [InlineData("Cheese Pizza")] //expectation on the outside of the test

        public void Test_CheesePizza_Theory(string expected)
        {
            // arrange
            var sut = new CheesePizza();

            // act
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);
        }
    }
}