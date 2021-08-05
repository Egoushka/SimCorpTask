using System;
using static System.Math;
using static SimCorpTask.DepositCalculationConstants;

namespace SimCorpTask
{
    public static class DepositCalculations
    {
        public static double CalculateByFormula(DateTime agreementDate, DateTime calculationTime, int startDeposit, double percentagePerYear)
        {
            int n = DateTimeTools.GetMonthsBetweenTwoDates(agreementDate, calculationTime);
            return startDeposit * Pow( Сoefficient + ((percentagePerYear / AnnualRateDivisor) / MonthsInYear), n);
        }

    }
}