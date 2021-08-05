using System;
using SimCorpTask;
using Xunit;

namespace Tests
{
    public class DepositCalculationTest
    {
        [Fact]
        public void ValidResult()
        {
            double result = DepositCalculations.CalculateByFormula(new DateTime(2020, 1, 1), new DateTime(2025, 1, 1),
                2314312, 14.71);
            
            Assert.Equal("4807326",$"{result:0}");
        }
        [Fact]
        public void AnotherValidResult()
        {
            double result = DepositCalculations.CalculateByFormula(new DateTime(2020, 1, 1), new DateTime(2020, 7, 1),
                192000, 0.1);
            
            Assert.Equal("192096",$"{result:0}");
        }
    }
}