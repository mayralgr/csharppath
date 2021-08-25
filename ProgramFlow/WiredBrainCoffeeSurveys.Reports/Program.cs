using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<String>();
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

            if(Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Investigate coffe recipes and ingredients.");
            }

            if (overallScore > 8.0)
            {
                tasks.Add("Work with leadearship to reward staff");
            } else
            {
                tasks.Add("Work with employees for improvement ideas.");
            }

            if(responseRate < .33)
            {
                tasks.Add("Research...");
            } else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffee coupon.");
            } else
            {
                tasks.Add("Reward participation with discount coffee coupon");
            }
        }
    }
}
