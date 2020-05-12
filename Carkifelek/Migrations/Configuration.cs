namespace Carkifelek.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Carkifelek.Context.CarkifelekContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Carkifelek.Context.CarkifelekContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Points.Add(new Entities.Point() { PointRate = 0, ProbabilityPercentage = 40 });
            context.Points.Add(new Entities.Point() { PointRate = 5, ProbabilityPercentage = 50 });
            context.Points.Add(new Entities.Point() { PointRate = 75, ProbabilityPercentage = 5 });
            context.Points.Add(new Entities.Point() { PointRate = 150, ProbabilityPercentage = 4 });
            context.Points.Add(new Entities.Point() { PointRate = 500, ProbabilityPercentage = 1 });

            //Default Rewards
            context.Rewards.Add(new Entities.Reward() { RewardName = "250 MB Internet Paketi", ProbabilityPercentage = 20, IsAllowedForGetPoint = true });
            context.Rewards.Add(new Entities.Reward() { RewardName = "1 GB Internet Paketi", ProbabilityPercentage = 5, IsAllowedForGetPoint = false });
            context.Rewards.Add(new Entities.Reward() { RewardName = "Boyner 25 TL Hediye Çeki", ProbabilityPercentage = 5, IsAllowedForGetPoint = false });
            context.Rewards.Add(new Entities.Reward() { RewardName = "Koton 10 TL Hediye Çeki", ProbabilityPercentage = 10, IsAllowedForGetPoint = true });
            context.Rewards.Add(new Entities.Reward() { RewardName = "Blu TV 1 Aylýk Abonelik", ProbabilityPercentage = 5, IsAllowedForGetPoint = false });
            context.Rewards.Add(new Entities.Reward() { RewardName = "10 TL Steam Cüzdan Kodu", ProbabilityPercentage = 10, IsAllowedForGetPoint = true });
            context.Rewards.Add(new Entities.Reward() { RewardName = "Karavana", ProbabilityPercentage = 45, IsAllowedForGetPoint = true });
        }
    }
}
