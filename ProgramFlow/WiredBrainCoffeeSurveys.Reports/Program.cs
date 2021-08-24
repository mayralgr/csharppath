using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

            double overallScore = (Q1Results.ServiceScore +Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;


            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered surveys: {unansweredCount}");

            bool higherCoffeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customerRecommend = Q1Results.WouldRecommend >=7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coofee Score Higher Than Food: {higherCoffeScore}");
            Console.WriteLine($"customes Would Recommend Us: {customerRecommend}");
            Console.WriteLine($"Hate Grano, Love Capuccino: {noGranolaYesCappucino}");

        }
    }
}
