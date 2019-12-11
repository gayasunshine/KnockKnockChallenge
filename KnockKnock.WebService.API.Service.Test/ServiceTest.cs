using System;
using Xunit;
using KnockKnockCodeChallenge.WebService.API.Service.Services;

namespace KnockKnock.WebService.API.Service.Test
{
    public class ServiceTest
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(0,0)]
        [InlineData(5,5)]
        [InlineData(-40, -102334155)]
        [InlineData(-1, 1)]
        [InlineData(15, 610)]
        public void Check_FibornacciNumberSerice(long number,long expected)
        {
            FibonacciNumberService service = new FibonacciNumberService();
            Assert.Equal(expected,service.GetFibonacciNumber(number));
        }


        [Theory]
        [InlineData("ACD", "DCA")]
        [InlineData("Ab F", "bA F")]
        [InlineData("", "")]
        [InlineData("A V B", "A V B")]

        public void Check_ReverseSentence_PositiveAndNegative(string input, string expected)
        {
            ReverseWordsService service = new ReverseWordsService();
            Assert.Equal(expected, service.GetReverseWord(input));
        }

        [Theory]
        [InlineData(2,4,5, "Scalene")]
        [InlineData(2,2,3, "Isosceles")]
        [InlineData(-2,3,4, "Error")]
        [InlineData(3,3,3, "Equilateral")]

        public void Check_Triangle_Typee(int a,int b,int c ,string expected)
        {
            TriangleTypeService service = new TriangleTypeService();
            Assert.Equal(expected, service.GetTriangleType(a,b,c));
        }
    }
}
